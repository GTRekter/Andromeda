using System;
using Microsoft.EntityFrameworkCore;
using Andromeda.Models.Data;

namespace Andromeda.Models
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        #region Global
        public DbSet<AN_Education> AN_Educations { get; set; }
        public DbSet<AN_School> AN_Schools { get; set; }
        public DbSet<AN_Image> AN_Images { get; set; }
        public DbSet<AN_Address> AN_Addresses { get; set; }
        public DbSet<AN_Country> AN_Countries { get; set; }
        public DbSet<AN_Person> AN_People { get; set; }
        public DbSet<AN_Skill> AN_Skills { get; set; }
        public DbSet<AN_Skill> AN_Fields { get; set; }
        public DbSet<AN_PersonAddress> AN_PersonAddresses { get; set; }
        public DbSet<AN_Company> AN_Companies { get; set; }
        public DbSet<AN_Experience> AN_Experiences { get; set; }
        public DbSet<AN_Testimonial> AN_Testimonials { get; set; }
        public DbSet<AN_Certification> AN_Certifications { get; set; }
        public DbSet<AN_Employee> AN_Employees { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Global
            modelBuilder.Entity<AN_Image>()
                .ToTable(name: "AN_Images", schema: "Global")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_Address>()
                .ToTable(name: "AN_Addresses", schema: "Global")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_Country>()
                .ToTable(name: "AN_Countries", schema: "Global")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_Skill>()
                .ToTable(name: "AN_Skills", schema: "Global")
                .HasKey(key => new { key.Id });
            #endregion

            #region Person
            modelBuilder.Entity<AN_Person>()
                .ToTable(name: "AN_People", schema: "Person")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_PersonAddress>()
                .ToTable(name: "AN_PersonAddresses", schema: "Person")
                .HasKey(key => new { key.Id });
            #endregion

            #region Education
            modelBuilder.Entity<AN_Education>()
                .ToTable(name: "AN_Educations", schema: "Education")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_School>()
                .ToTable(name: "AN_Schools", schema: "Education")
                .HasKey(key => new { key.Id });
            #endregion

            #region Company
            modelBuilder.Entity<AN_Experience>()
                .ToTable(name: "AN_Experiences", schema: "Experience")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_Company>()
                .ToTable(name: "AN_Companies", schema: "Experience")
                .HasKey(key => new { key.Id });
            modelBuilder.Entity<AN_Employee>()
                .ToTable(name: "AN_Employees", schema: "Experience")
                .HasKey(key => new { key.Id });
            #endregion

            #region Testimonial
            modelBuilder.Entity<AN_Testimonial>()
                .ToTable(name: "AN_Testimonials", schema: "Testimonial")
                .HasKey(key => new { key.Id });
            #endregion

            #region Certification
            modelBuilder.Entity<AN_Certification>()
                .ToTable(name: "AN_Certifications", schema: "Certification")
                .HasKey(key => new { key.Id });
            #endregion

            #region DataSeed
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 1, Fips = "AA", Iso = "AW", Name = "Aruba" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 2, Fips = "AC", Iso = "AG", Name = "Antigua and Barbuda" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 3, Fips = "AE", Iso = "AE", Name = "United Arab Emirates" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 4, Fips = "AF", Iso = "AF", Name = "Afghanistan" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 5, Fips = "AG", Iso = "DZ", Name = "Algeria" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 6, Fips = "AJ", Iso = "AZ", Name = "Azerbaijan" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 7, Fips = "AL", Iso = "AL", Name = "Albania" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 8, Fips = "AM", Iso = "AM", Name = "Armenia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 9, Fips = "AN", Iso = "AD", Name = "Andorra" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 10, Fips = "AO", Iso = "AO", Name = "Angola" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 11, Fips = "AQ", Iso = "AS", Name = "American Samoa" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 12, Fips = "AR", Iso = "AR", Name = "Argentina" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 13, Fips = "AS", Iso = "AU", Name = "Australia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 14, Fips = "AT", Iso = null, Name = "Ashmore and Cartier Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 15, Fips = "AU", Iso = "AT", Name = "Austria" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 16, Fips = "AV", Iso = "AI", Name = "Anguilla" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 17, Fips = "AX", Iso = "AX", Name = "Åland Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 18, Fips = "AY", Iso = "AQ", Name = "Antarctica" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 19, Fips = "AY", Iso = "AQ", Name = "Antarctica" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 20, Fips = "BA", Iso = "BH", Name = "Bahrain" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 21, Fips = "BB", Iso = "BB", Name = "Barbados" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 22, Fips = "BC", Iso = "BW", Name = "Botswana" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 23, Fips = "BD", Iso = "BM", Name = "Bermuda" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 24, Fips = "BE", Iso = "BE", Name = "Belgium" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 25, Fips = "BF", Iso = "BS", Name = "Bahamas, The" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 26, Fips = "BG", Iso = "BD", Name = "Bangladesh" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 27, Fips = "BH", Iso = "BZ", Name = "Belize" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 28, Fips = "BK", Iso = "BA", Name = "Bosnia and Herzegovina" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 29, Fips = "BL", Iso = "BO", Name = "Bolivia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 30, Fips = "BM", Iso = "MM", Name = "Myanmar" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 31, Fips = "BN", Iso = "BJ", Name = "Benin" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 32, Fips = "BO", Iso = "BY", Name = "Belarus" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 33, Fips = "BP", Iso = "SB", Name = "Solomon Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 34, Fips = "BQ", Iso = null, Name = "Navassa Island" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 35, Fips = "BR", Iso = "BR", Name = "Brazil" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 36, Fips = "BS", Iso = null, Name = "Bassas da India" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 37, Fips = "BT", Iso = "BT", Name = "Bhutan" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 38, Fips = "BU", Iso = "BG", Name = "Bulgaria" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 39, Fips = "BV", Iso = "BV", Name = "Bouvet Island" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 40, Fips = "BX", Iso = "BN", Name = "Brunei" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 41, Fips = "BY", Iso = "BI", Name = "Burundi" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 42, Fips = "CA", Iso = "CA", Name = "Canada" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 43, Fips = "CB", Iso = "KH", Name = "Cambodia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 44, Fips = "CD", Iso = "TD", Name = "Chad" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 45, Fips = "CE", Iso = "LK", Name = "Sri Lanka" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 46, Fips = "CF", Iso = "CG", Name = "Congo, Republic of the" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 47, Fips = "CG", Iso = "CD", Name = "Congo, Democratic Republic of the" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 48, Fips = "CH", Iso = "CN", Name = "China" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 49, Fips = "CI", Iso = "CL", Name = "Chile" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 50, Fips = "CJ", Iso = "KY", Name = "Cayman Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 51, Fips = "CK", Iso = "CC", Name = "Cocos (Keeling) Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 52, Fips = "CM", Iso = "CM", Name = "Cameroon" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 53, Fips = "CN", Iso = "KM", Name = "Comoros" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 54, Fips = "CO", Iso = "CO", Name = "Colombia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 55, Fips = "CQ", Iso = "MP", Name = "Northern Mariana Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 56, Fips = "CR", Iso = null, Name = "Coral Sea Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 57, Fips = "CS", Iso = "CR", Name = "Costa Rica" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 58, Fips = "CT", Iso = "CF", Name = "Central African Republic" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 59, Fips = "CU", Iso = "CU", Name = "Cuba" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 60, Fips = "CV", Iso = "CV", Name = "Cape Verde" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 61, Fips = "CW", Iso = "CK", Name = "Cook Islands" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 62, Fips = "CY", Iso = "CY", Name = "Cyprus" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 63, Fips = "DA", Iso = "DK", Name = "Denmark" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 64, Fips = "DJ", Iso = "DJ", Name = "Djibouti" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 65, Fips = "DO", Iso = "DM", Name = "Dominica" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 66, Fips = "DQ", Iso = "UM", Name = "Jarvis Island" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 67, Fips = "DR", Iso = "DO", Name = "Dominican Republic" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 68, Fips = "DX", Iso = null, Name = "Dhekelia Sovereign Base Area" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 69, Fips = "EC", Iso = "EC", Name = "Ecuador" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 70, Fips = "EG", Iso = "EG", Name = "Egypt" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 71, Fips = "EI", Iso = "IE", Name = "Ireland" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 72, Fips = "EK", Iso = "GQ", Name = "Equatorial Guinea"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 73, Fips = "EN", Iso = "EE", Name = "Estonia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 74, Fips = "ER", Iso = "ER", Name = "Eritrea"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 75, Fips = "ES", Iso = "SV", Name = "El Salvador"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 76, Fips = "ET", Iso = "ET", Name = "Ethiopia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 77, Fips = "EU", Iso = null, Name = "Europa Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 78, Fips = "EZ", Iso = "CZ", Name = "Czech Republic"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 79, Fips = "FG", Iso = "GF", Name = "French Guiana"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 80, Fips = "FI", Iso = "FI", Name = "Finland"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 81, Fips = "FJ", Iso = "FJ", Name = "Fiji"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 82, Fips = "FK", Iso = "FK", Name = "Falkland Islands (Islas Malvinas)"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 83, Fips = "FM", Iso = "FM", Name = "Micronesia, Federated States of"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 84, Fips = "FO", Iso = "FO", Name = "Faroe Islands"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 85, Fips = "FP", Iso = "PF", Name = "French Polynesia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 86, Fips = "FQ", Iso = "UM", Name = "Baker Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 87, Fips = "FR", Iso = "FR", Name = "France"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 88, Fips = "FS", Iso = "TF", Name = "French Southern and Antarctic Lands"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 89, Fips = "GA", Iso = "GM", Name = "Gambia, The"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 90, Fips = "GB", Iso = "GA", Name = "Gabon"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 91, Fips = "GG", Iso = "GE", Name = "Georgia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 92, Fips = "GH", Iso = "GH", Name = "Ghana"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 93, Fips = "GI", Iso = "GI", Name = "Gibraltar"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 94, Fips = "GJ", Iso = "GD", Name = "Grenada"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 95, Fips = "GK", Iso = null, Name = "Guernsey"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 96, Fips = "GL", Iso = "GL", Name = "Greenland"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 97, Fips = "GM", Iso = "DE", Name = "Germany"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 98, Fips = "GO", Iso = null, Name = "Glorioso Islands"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 99, Fips = "GP", Iso = "GP", Name = "Guadeloupe"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 100, Fips = "GQ", Iso = "GU", Name = "Guam"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 101, Fips = "GR", Iso = "GR", Name = "Greece"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 102, Fips = "GT", Iso = "GT", Name = "Guatemala"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 103, Fips = "GV", Iso = "GN", Name = "Guinea"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 104, Fips = "GY", Iso = "GY", Name = "Guyana"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 105, Fips = "GZ", Iso = null, Name = "Gaza Strip"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 106, Fips = "HA", Iso = "HT", Name = "Haiti"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 107, Fips = "HK", Iso = "HK", Name = "Hong Kong"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 108, Fips = "HM", Iso = "HM", Name = "Heard Island and McDonald Islands"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 109, Fips = "HO", Iso = "HN", Name = "Honduras"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 110, Fips = "HQ", Iso = "UM", Name = "Howland Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 111, Fips = "HR", Iso = "HR", Name = "Croatia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 112, Fips = "HU", Iso = "HU", Name = "Hungary"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 113, Fips = "IC", Iso = "IS", Name = "Iceland"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 114, Fips = "ID", Iso = "ID", Name = "Indonesia"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 115, Fips = "IM", Iso = "IM", Name = "Isle of Man"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 116, Fips = "IN", Iso = "IN", Name = "India"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 117, Fips = "IO", Iso = "IO", Name = "British Indian Ocean Territory"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 118, Fips = "IP", Iso = null, Name = "Clipperton Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 119, Fips = "IR", Iso = "IR", Name = "Iran"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 120, Fips = "IS", Iso = "IL", Name = "Israel"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 121, Fips = "IT", Iso = "IT", Name = "Italy"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 122, Fips = "IV", Iso = "CI", Name = "Cote d\"Ivoire"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 123, Fips = "IZ", Iso = "IQ", Name = "Iraq"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 124, Fips = "JA", Iso = "JP", Name = "Japan"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 125, Fips = "JE", Iso = "JE", Name = "Jersey"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 126, Fips = "JM", Iso = "JM", Name = "Jamaica"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 127, Fips = "JN", Iso = "SJ", Name = "Jan Mayen"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 128, Fips = "JO", Iso = "JO", Name = "Jordan"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 129, Fips = "JQ", Iso = "UM", Name = "Johnston Atoll"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 130, Fips = "JU", Iso = null, Name = "Juan de Nova Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 131, Fips = "KE", Iso = "KE", Name = "Kenya"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 132, Fips = "KG", Iso = "KG", Name = "Kyrgyzstan"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 133, Fips = "KN", Iso = "KP", Name = "Korea, North"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 134, Fips = "KQ", Iso = "UM", Name = "Kingman Reef"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 135, Fips = "KR", Iso = "KI", Name = "Kiribati"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 136, Fips = "KS", Iso = "KR", Name = "Korea, South"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 137, Fips = "KT", Iso = "CX", Name = "Christmas Island"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 138, Fips = "KU", Iso = "KW", Name = "Kuwait" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 139, Fips = "KV", Iso = "KV", Name = "Kosovo" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 140, Fips = "KZ", Iso = "KZ", Name = "Kazakhstan" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 141, Fips = "LA", Iso = "LA", Name = "Laos" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 142, Fips = "LE", Iso = "LB", Name = "Lebanon" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 143, Fips = "LG", Iso = "LV", Name = "Latvia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 144, Fips = "LH", Iso = "LT", Name = "Lithuania" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 145, Fips = "LI", Iso = "LR", Name = "Liberia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 146, Fips = "LO", Iso = "SK", Name = "Slovakia" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 147, Fips = "LQ", Iso = "UM", Name = "Palmyra Atoll" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 148, Fips = "LS", Iso = "LI", Name = "Liechtenstein" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 149, Fips = "LT", Iso = "LS", Name = "Lesotho" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 150, Fips = "LU", Iso = "LU", Name = "Luxembourg" });
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 151, Fips = "LY", Iso = "LY", Name = "Libyan Arab"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 152, Fips = "MA", Iso = "MG", Name = "Madagascar"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 153, Fips = "MB", Iso = "MQ", Name = "Martinique"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 154, Fips = "MC", Iso = "MO", Name = "Macau"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 155, Fips = "MD", Iso = "MD", Name = "Moldova, Republic of"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 156, Fips = "MF", Iso = "YT", Name = "Mayotte"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 157, Fips = "MG", Iso = "MN", Name = "Mongolia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 158, Fips = "MH", Iso = "MS", Name = "Montserrat"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 159, Fips = "MI", Iso = "MW", Name = "Malawi"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 160, Fips = "MJ", Iso = "ME", Name = "Montenegro"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 161, Fips = "MK", Iso = "MK", Name = "The Former Yugoslav Republic of Macedonia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 162, Fips = "ML", Iso = "ML", Name = "Mali"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 163, Fips = "MN", Iso = "MC", Name = "Monaco"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 164, Fips = "MO", Iso = "MA", Name = "Morocco"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 165, Fips = "MP", Iso = "MU", Name = "Mauritius"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 166, Fips = "MQ", Iso = "UM", Name = "Midway Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 167, Fips = "MR", Iso = "MR", Name = "Mauritania"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 168, Fips = "MT", Iso = "MT", Name = "Malta"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 169, Fips = "MU", Iso = "OM", Name = "Oman"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 170, Fips = "MV", Iso = "MV", Name = "Maldives"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 171, Fips = "MX", Iso = "MX", Name = "Mexico"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 172, Fips = "MY", Iso = "MY", Name = "Malaysia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 173, Fips = "MZ", Iso = "MZ", Name = "Mozambique"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 174, Fips = "NC", Iso = "NC", Name = "New Caledonia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 175, Fips = "NE", Iso = "NU", Name = "Niue"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 176, Fips = "NF", Iso = "NF", Name = "Norfolk Island"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 177, Fips = "NG", Iso = "NE", Name = "Niger"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 178, Fips = "NH", Iso = "VU", Name = "Vanuatu"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 179, Fips = "NI", Iso = "NG", Name = "Nigeria"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 180, Fips = "NL", Iso = "NL", Name = "Netherlands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 181, Fips = "NM", Iso = null, Name = "No Man\"s Land"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 182, Fips = "NO", Iso = "NO", Name = "Norway"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 183, Fips = "NP", Iso = "NP", Name = "Nepal"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 184, Fips = "NR", Iso = "NR", Name = "Nauru"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 185, Fips = "NS", Iso = "SR", Name = "Suriname"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 186, Fips = "NT", Iso = "AN", Name = "Netherlands Antilles"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 187, Fips = "NU", Iso = "NI", Name = "Nicaragua"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 188, Fips = "NZ", Iso = "NZ", Name = "New Zealand"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 189, Fips = "PA", Iso = "PY", Name = "Paraguay"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 190, Fips = "PC", Iso = "PN", Name = "Pitcairn Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 191, Fips = "PE", Iso = "PE", Name = "Peru"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 192, Fips = "PF", Iso = null, Name = "Paracel Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 193, Fips = "PG", Iso = null, Name = "Spratly Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 194, Fips = "PK", Iso = "PK", Name = "Pakistan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 195, Fips = "PL", Iso = "PL", Name = "Poland"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 196, Fips = "PM", Iso = "PA", Name = "Panama"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 197, Fips = "PO", Iso = "PT", Name = "Portugal"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 198, Fips = "PP", Iso = "PG", Name = "Papua New Guinea"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 199, Fips = "PS", Iso = "PW", Name = "Palau"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 200, Fips = "PU", Iso = "GW", Name = "Guinea-Bissau"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 201, Fips = "QA", Iso = "QA", Name = "Qatar"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 202, Fips = "RE", Iso = "RE", Name = "Reunion"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 203, Fips = "RI", Iso = "RS", Name = "Serbia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 204, Fips = "RM", Iso = "MH", Name = "Marshall Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 205, Fips = "RN", Iso = "MF", Name = "Saint Martin"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 206, Fips = "RO", Iso = "RO", Name = "Romania"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 207, Fips = "RP", Iso = "PH", Name = "Philippines"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 208, Fips = "RQ", Iso = "PR", Name = "Puerto Rico"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 209, Fips = "RS", Iso = "RU", Name = "Russia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 210, Fips = "RW", Iso = "RW", Name = "Rwanda"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 211, Fips = "SA", Iso = "SA", Name = "Saudi Arabia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 212, Fips = "SB", Iso = "PM", Name = "Saint Pierre and Miquelon"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 213, Fips = "SC", Iso = "KN", Name = "Saint Kitts and Nevis"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 214, Fips = "SE", Iso = "SC", Name = "Seychelles"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 215, Fips = "SF", Iso = "ZA", Name = "South Africa"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 216, Fips = "SG", Iso = "SN", Name = "Senegal"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 217, Fips = "SH", Iso = "SH", Name = "Saint Helena"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 218, Fips = "SI", Iso = "SI", Name = "Slovenia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 219, Fips = "SL", Iso = "SL", Name = "Sierra Leone"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 220, Fips = "SM", Iso = "SM", Name = "San Marino"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 221, Fips = "SN", Iso = "SG", Name = "Singapore"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 222, Fips = "SO", Iso = "SO", Name = "Somalia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 223, Fips = "SP", Iso = "ES", Name = "Spain"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 224, Fips = "ST", Iso = "LC", Name = "Saint Lucia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 225, Fips = "SU", Iso = "SD", Name = "Sudan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 226, Fips = "SV", Iso = "SJ", Name = "Svalbard"});
            modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 227, Fips = "SW", Iso = "SE", Name = "Sweden"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 228, Fips = "SX", Iso = "GS", Name = "South Georgia and the Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 229, Fips = "SY", Iso = "SY", Name = "Syrian Arab Republic"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 230, Fips = "SZ", Iso = "CH", Name = "Switzerland"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 231, Fips = "TD", Iso = "TT", Name = "Trinidad and Tobago"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 232, Fips = "TE", Iso = null, Name = "Tromelin Island"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 233, Fips = "TH", Iso = "TH", Name = "Thailand"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 234, Fips = "TI", Iso = "TJ", Name = "Tajikistan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 235, Fips = "TK", Iso = "TC", Name = "Turks and Caicos Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 236, Fips = "TL", Iso = "TK", Name = "Tokelau"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 237, Fips = "TN", Iso = "TO", Name = "Tonga"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 238, Fips = "TO", Iso = "TG", Name = "Togo"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 239, Fips = "TP", Iso = "ST", Name = "Sao Tome and Principe"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 240, Fips = "TS", Iso = "TN", Name = "Tunisia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 241, Fips = "TT", Iso = "TL", Name = "East Timor"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 242, Fips = "TU", Iso = "TR", Name = "Turkey"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 243, Fips = "TV", Iso = "TV", Name = "Tuvalu"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 244, Fips = "TW", Iso = "TW", Name = "Taiwan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 245, Fips = "TX", Iso = "TM", Name = "Turkmenistan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 246, Fips = "TZ", Iso = "TZ", Name = "Tanzania, United Republic of"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 247, Fips = "UG", Iso = "UG", Name = "Uganda"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 248, Fips = "UK", Iso = "GB", Name = "United Kingdom"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 249, Fips = "UP", Iso = "UA", Name = "Ukraine"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 250, Fips = "US", Iso = "US", Name = "United States"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 251, Fips = "UV", Iso = "BF", Name = "Burkina Faso"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 252, Fips = "UY", Iso = "UY", Name = "Uruguay"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 253, Fips = "UZ", Iso = "UZ", Name = "Uzbekistan"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 254, Fips = "VC", Iso = "VC", Name = "Saint Vincent and the Grenadines"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 255, Fips = "VE", Iso = "VE", Name = "Venezuela"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 256, Fips = "VI", Iso = "VG", Name = "British Virgin Islands"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 257, Fips = "VM", Iso = "VN", Name = "Vietnam"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 258, Fips = "VQ", Iso = "VI", Name = "Virgin Islands (US)"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 259, Fips = "VT", Iso = "VA", Name = "Holy See (Vatican City)"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 260, Fips = "WA", Iso = "NA", Name = "Namibia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 261, Fips = "WE", Iso = null, Name = "West Bank"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 262, Fips = "WF", Iso = "WF", Name = "Wallis and Futuna"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 263, Fips = "WI", Iso = "EH", Name = "Western Sahara"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 264, Fips = "WQ", Iso = "UM", Name = "Wake Island"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 265, Fips = "WS", Iso = "WS", Name = "Samoa"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 266, Fips = "WZ", Iso = "SZ", Name = "Swaziland"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 267, Fips = "YI", Iso = "CS", Name = "Serbia and Montenegro"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 268, Fips = "YM", Iso = "YE", Name = "Yemen"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 269, Fips = "ZA", Iso = "ZM", Name = "Zambia"});
	        modelBuilder.Entity<AN_Country>().HasData(new AN_Country { Id = 270, Fips = "ZI", Iso = "ZW", Name = "Zimbabwe" });

            #endregion
        }
    }
}