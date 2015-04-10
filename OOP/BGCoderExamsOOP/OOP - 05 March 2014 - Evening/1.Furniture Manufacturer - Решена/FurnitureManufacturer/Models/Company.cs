namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private const string NameArgumentNullExceptionErrorMessage = "Name cannot be empty or null.";
        private const string NameMinimumLenghtErrorMessage = "Name length cannot be less than {0} symbols.";
        private const string RegistrationNumberMinimumLengthErrorMessage = "The registration number length must be exactly {0} symbols";
        private const string RegistrationNumberArgumentNullExceptionErrorMessage = "The registration number cannot be empty or null";
        private const string RegistrationNumberDigitsErrorMessage = "The registration number must contain only digits.";
        private const string FurnitureNullExceptionErrorMessage = "Furniture cannot be null.";
        private const string CatalogToStringFormat = "{0} - {1} - {2} {3}";
        private const string NoFurnituresFoundMessage = "no";
        private const string ManyFurnituresMessage = "furnitures";
        private const string OneFurnitureMessage = "furniture";
        private const int NumberOfFurnituresZero = 0;
        private const int NumberOfFurnituresOne = 1;
        private const int NameMinimumLenghtValue = 5;
        private const int RegistrationNumberMinimumLenghtValue = 10;

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnituresList;

        public Company(string setName, string setRegistrationNumber)
        {
            this.Name = setName;
            this.RegistrationNumber = setRegistrationNumber;
            this.furnituresList = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameArgumentNullExceptionErrorMessage);
                }

                if (value.Length < NameMinimumLenghtValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format(NameMinimumLenghtErrorMessage, NameMinimumLenghtValue));
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(RegistrationNumberArgumentNullExceptionErrorMessage);
                }

                if (value.Length != RegistrationNumberMinimumLenghtValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format(RegistrationNumberMinimumLengthErrorMessage, 
                        RegistrationNumberMinimumLenghtValue));
                }

                if (value.Any(ch => !char.IsDigit(ch)))
                {
                    throw new ArgumentException(RegistrationNumberDigitsErrorMessage);
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnituresList); // creating new list 
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException(FurnitureNullExceptionErrorMessage);
            }

            this.furnituresList.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException(FurnitureNullExceptionErrorMessage);
            }

            this.furnituresList.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnituresList.FirstOrDefault(fn => fn.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder catalogToString = new StringBuilder();

            catalogToString.AppendLine(
                    string.Format(CatalogToStringFormat,
                    this.Name,
                    this.RegistrationNumber,
                    this.Furnitures.Count != NumberOfFurnituresZero ? this.Furnitures.Count.ToString() : NoFurnituresFoundMessage,
                    this.Furnitures.Count != NumberOfFurnituresOne ? ManyFurnituresMessage : OneFurnitureMessage));

            var sortedFurnitures = this.furnituresList.OrderBy(fn => fn.Price).ThenBy(fn => fn.Model);

            foreach (var furniture in sortedFurnitures)
            {
                catalogToString.AppendLine(furniture.ToString());
            }

            return catalogToString.ToString().Trim();
        }
    }
}
