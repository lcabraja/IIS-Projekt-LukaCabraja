using model;
using System.Collections.Generic;

namespace api
{
    public class MockData
    {
        public static List<User> Generate()
        {
            return new List<User>
            {
                new User
                {
                    ID = "lcabraja-id",
                    Username = "lcabraja",
                    PasswordHash = "1234567890",
                    Images = new List<Image>
                    {
                        new Image
                        {
                            ResourceTitle = "Fox 1",
                            ResourceURL = "https://randomfox.ca/images/1.jpg",
                            IsFavorite = true
                        },
                        new Image
                        {
                            ResourceTitle = "Fox 2",
                            ResourceURL = "https://randomfox.ca/images/2.jpg",
                            IsFavorite = false
                        },
                        new Image
                        {
                            ResourceTitle = "Fox 3",
                            ResourceURL = "https://randomfox.ca/images/3.jpg",
                            IsFavorite = false
                        }
                    }
                },
                new User
                {
                    ID = "jkustan-id",
                    Username = "jkustan",
                    PasswordHash = "kraljzvrki",
                    Images = new List<Image>
                    {
                        new Image
                        {
                            ResourceTitle = "Fox 4",
                            ResourceURL = "https://randomfox.ca/images/4.jpg",
                            IsFavorite = false
                        },
                        new Image
                        {
                            ResourceTitle = "Fox 5",
                            ResourceURL = "https://randomfox.ca/images/5.jpg",
                            IsFavorite = true
                        },
                        new Image
                        {
                            ResourceTitle = "Fox 6",
                            ResourceURL = "https://randomfox.ca/images/6.jpg",
                            IsFavorite = false
                        }
                    }
                }
            };
        }
    }
}
