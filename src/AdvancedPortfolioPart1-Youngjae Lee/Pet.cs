using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedPortfolioPart1_Youngjae_Lee
{
    class Pet
    {
        //fields
        private string _name = "No name assigned";
        private int _age = 0;
        private double _weight = 0;
        private string _pet_type = "dog";

        //No parameter constructor
        public Pet()
        {

        }

        //parameterized constructor
        public Pet(string name, int age, double weight, string pet_type)
        {
            Name = name;
            Age = age;
            Weight = weight;
            PetType = pet_type;
        }

        //getter and setter for the name field
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        //getter and setter for the age field
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if(value > 0)
                {
                    _age = value;
                }

                else
                {
                    throw new Exception($"Age must be greater than zero");
                }
            }
        }

        //getter and setter for the weight field
        public double Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if(value > 0)
                {
                    _weight = value;
                }

                else
                {
                    throw new Exception($"Weight must be greater than zero");
                }
            }
        }

        //getter and setter for the pet type field
        public string PetType
        {
            get
            {
                return _pet_type;
            }

            set
            {
                _pet_type = value;
            }
        }

        //acepromazine method
        public double Acepromazine()
        {
            //declaring a double variable that stores the dosage
            double dosage;

            //if pet type is dog
            if (_pet_type.ToLower() == "dog")
            {
                //calculating the dosage and rounding it to 4 decimal places
                dosage = Math.Round(((_weight / 2.20462) * (0.03 / 10)), 4);
            }

            //if it is cat
            else
            {
                //calculating the dosage and rounding it to 4 decimal places
                dosage = Math.Round(((_weight / 2.20462) * (0.002 / 10)), 4);
            }

            //returning dosage
            return dosage;
        }

        //carprofen method
        public double Carprofen()
        {
            //declaring a double variable that stores the dosage
            double dosage;

            //if pet type is dog
            if (_pet_type.ToLower() == "dog")
            {
                //calculating the dosage and rounding it to 4 decimal places
                dosage = Math.Round(((_weight / 2.20462) * (0.5 / 12)), 4);
            }

            //if it is cat
            else
            {
                //calculating the dosage and rounding it to 4 decimal places
                dosage = Math.Round(((_weight / 2.20462) * (0.25 / 12)), 4);
            }

            //returning dosage
            return dosage;
        }


    }
}
