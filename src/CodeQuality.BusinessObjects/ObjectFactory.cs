namespace CodeQuality.BusinessObjects
{
    using System;

    public static class ObjectFactory
    {
        public static BusinessObject GetObject(string objectCode, string firstName, string lastName)
        {
            objectCode = objectCode.ToUpper();

            if (objectCode == null)
            {
                throw new ArgumentException("Object code is null!");
            }

            if (objectCode.EndsWith("CUST"))
            {
                return new Customer(firstName, lastName);
            }
            else if (objectCode.EndsWith("MGR"))
            {
                return new Manager(firstName, lastName);
            }

            if (objectCode.Contains("PHASE2"))
            {
                return new Customer2(firstName, lastName);
            }

            switch(objectCode.Substring(2, 3))
            {
                case "USD":
                    if (objectCode.Length < 10)
                    {
                        lastName = "DOMESTIC";
                    }
                    else
                    {
                        lastName = "INTERNATIONAL";
                    }

                    return new USCustomer(firstName, lastName);
                case "GBP":
                    if (objectCode.Length < 10)
                    {
                        lastName = "BUSINESS";
                    }
                    else
                    {
                        lastName = "INDIVIDUAL";
                    }

                    return new UKCustomer(lastName, firstName);
            }

            if (objectCode == null)
            {
                if (string.IsNullOrEmpty(objectCode))
                {
                    objectCode = "EMPTY";
                }
                else
                {
                    try
                    {
                        return new Person(firstName, lastName);
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            throw new Exception("Object code is not supported");

            return new BusinessObject();
        }
    }
}
