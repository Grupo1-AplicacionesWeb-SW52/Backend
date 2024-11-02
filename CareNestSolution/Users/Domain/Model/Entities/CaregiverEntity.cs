using CareNestSolution.Users.Domain.Model.ValueObjects;

namespace CareNestSolution.Users.Domain.Model.Entities;

    public class CaregiverEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string ProfilePicture { get; private set; }
        public string Role { get; private set; }
        public double Rating { get; private set; }
        public string Phone { get; private set; }
        public string Location { get; private set; }
        public string Address { get; private set; }
        public AdditionalInfo AdditionalInfo { get; private set; }
        public Availability Availability { get; private set; }

        public CaregiverEntity(int id, string name, string email, string password, string profilePicture, string role, double rating, string phone, string location, string address, AdditionalInfo additionalInfo, Availability availability)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            ProfilePicture = profilePicture;
            Role = role;
            Rating = rating;
            Phone = phone;
            Location = location;
            Address = address;
            AdditionalInfo = additionalInfo;
            Availability = availability;
        }
        
    } 