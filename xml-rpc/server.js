import fetch from "node-fetch";
import { createRequire } from "module";
import { XMLSerializer } from "xmldom";
const xmlSerializer = new XMLSerializer();
const require = createRequire(import.meta.url);
const xpath = require('xpath');
const xmlrpc = require("davexmlrpc");
const parser = require('xml2json');
const dom = require('xmldom').DOMParser;
const select = xpath.useNamespaces({ "x": "http://www.w3.org/1999/xhtml" });

const config = {
    port: 4040,
    xmlRpcPath: "/rpc"
}

const nodeToObject = (node) => {
    const str = pruneXml(xmlSerializer.serializeToString(node));
    const json = parser.toJson(str);
    const result = JSON.parse(json);
    return result;
}

const pruneXml = (str) =>
    str.replace(/[^\d a-zA-Z??žš???ŽŠ?"<>./=-]/g, '');

const findCityByName = (doc, city) => {
    const xpathcitybyname = `//Grad[GradIme='${city}']`;
    const nodes = select(xpathcitybyname, doc);
    return nodes.length > 0 ? nodeToObject(nodes[0]) : null;
}

const findFirstCity = (doc) => {
    const xpathcityfirst = `//Grad[1]`;
    const nodes = select(xpathcityfirst, doc);
    const str = pruneXml(xmlSerializer.serializeToString(nodes[0]));
    const json = parser.toJson(str);
    const result = JSON.parse(json);
    return result;
}

const findCityNames = (doc) => {
    const xpathcitynames = `//Grad/GradIme`;
    const nodes = select(xpathcitynames, doc);
    const names = nodes.map(n => n.firstChild.data);
    return names;
}

const fetchWeatherData = async () => {
    console.log("Fetching weather data ...");
    const dhmzdata = await (await fetch("https://vrijeme.hr/hrvatska_n.xml")).text();
    const doc = new dom().parseFromString(dhmzdata, 'text/xml');
    console.log(`DHMZ Data Length: [${dhmzdata.length}]`);
    return doc;
}

// (async () => {
//     const weatherData = await fetchWeatherData();
//     const firstcity = findFirstCity(weatherData);
//     const cities = findCityNames(weatherData);
//     const cityname = findCityByName(weatherData, cities[1]);

//     console.log(`[FirstCity]: ${JSON.stringify(firstcity)}`);
//     console.log(`[CityList]: ${cities}`);
//     console.log(`[CityByName]: ${JSON.stringify(cityname)}`);
// })()

xmlrpc.startServerOverHttp(config, async (request) => {
    const doc = await fetchWeatherData();
    switch (request.verb) {
        case "cityname":
            if (request.params.length > 0 && request.params[0] && request.params[0] != null) {
                console.log("[cityname] Executing function...");
                console.log(`City: [${request.params[0]}]`);
                const city = request.params[0];
                const cityByName = await findCityByName(doc, city);
                request.returnVal(undefined, { xml: cityByName });
            }
            else {
                request.returnVal({ message: "Bad input parameters" });
            }
            return (true);
        case "listcities":
            console.log("[listcities] Executing function...");
            const cityNames = findCityNames(doc);
            request.returnVal(undefined, { xml: cityNames });
            return (true);
        case "firstcity":
            console.log("[firstcity] Executing function...");
            const firstCity = findFirstCity(doc);
            request.returnVal(undefined, { xml: firstCity });
            return (true);
    }
    return (false);
});