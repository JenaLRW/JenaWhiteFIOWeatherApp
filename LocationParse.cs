namespace JenaWhiteFIOWeatherApp
{
    public class LocationParse
    {
        //this class is responsible for parsing the location string from the user's input.  The city will be the variable "name" and used in Geocode API call.  
        //Then with Geocode API results, we use the stateAbbreviation's full name (full name is in dictionary StateAbbreviations) to filter the results to get the city AND stateAbbreviation.
        //Once we have that, we make an API call to the forecast API to get the weather for that city and stateAbbreviation.

        public static (string city, string state) ParseLocation(string location)
        {
            // Split the input by commas and trim whitespace
            var parts = location.Split(',').Select(p => p.Trim()).ToArray();
            // The first part is the city, the second part is the stateAbbreviation
            string city = parts[0].Trim();
            string stateAbbreviation = parts[1].Trim().ToUpper();
            // Check if we have at least two parts (city and stateAbbreviation)
            if (parts.Length < 2)
            {
                throw new ArgumentException("Location must be in the format 'City, State'");
            }
            if (string.IsNullOrWhiteSpace(stateAbbreviation))

            {
                throw new ArgumentException("State abbreviation cannot be null or empty.");

            }   
            
            
            // Validate the stateAbbreviation against the dictionary
            if (!StateAbbreviations.StateAbbreviationsDict.ContainsKey(stateAbbreviation))
            {
                throw new ArgumentException($"State '{stateAbbreviation}' is not valid. Please use a valid state abbreviation (e.g. 'KY').");
            }

            string fullStateName = StateAbbreviations.StateAbbreviationsDict.FirstOrDefault(x => x.Value == stateAbbreviation).Key;
            return (city, fullStateName);
        }
    }
}
