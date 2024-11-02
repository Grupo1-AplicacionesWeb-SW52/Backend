using CareNestSolution.CareNest.Domain.Model.Commands;

namespace CareNestSolution.CareNest.Domain.Model.Aggregate;

public class CaregiverAggregate
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
        public Dictionary<string, string> Availability { get; private set; }
        
        public CaregiverAggregate(CreateCaregiverCommand command)
        {
            Id = 0; 
            Name = command.Name;
            Email = command.Email;
            Password = command.Password;
            ProfilePicture = command.ProfilePicture;
            Role = command.Role;
            Rating = command.Rating;
            Phone = command.Phone;
            Location = command.Location;
            Address = command.Address;
            AdditionalInfo = command.AdditionalInfo;
            Availability = command.Availability;
        }
        
        public void UpdateCaregiver(UpdateCaregiverCommand command)
        {
            if (!string.IsNullOrEmpty(command.Name)) Name = command.Name;
            if (!string.IsNullOrEmpty(command.Email)) Email = command.Email;
            if (!string.IsNullOrEmpty(command.Password)) Password = command.Password;
            if (!string.IsNullOrEmpty(command.ProfilePicture)) ProfilePicture = command.ProfilePicture;
            if (!string.IsNullOrEmpty(command.Role)) Role = command.Role;
            if (command.Rating.HasValue) Rating = command.Rating.Value;
            if (!string.IsNullOrEmpty(command.Phone)) Phone = command.Phone;
            if (!string.IsNullOrEmpty(command.Location)) Location = command.Location;
            if (!string.IsNullOrEmpty(command.Address)) Address = command.Address;
            if (command.AdditionalInfo != null) AdditionalInfo = command.AdditionalInfo;
            if (command.Availability != null) Availability = command.Availability;
        }
    }