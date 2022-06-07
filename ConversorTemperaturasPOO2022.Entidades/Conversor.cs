namespace ConversorTemperaturasPOO2022.Entidades
{
    public static class Conversor
    {
        private static float CeroAbsoluto = 273.15f;
        public static float ConvertirDeCelsiusAKelvin(float celsius)
        {
            return celsius + CeroAbsoluto;
        }

        public static float ConvertirDeKelvinACelsius(float kelvin)
        {
            return kelvin - CeroAbsoluto;
        }

        public static float ConvertirDeCelsiusAFahrenheit(float celsius)
        {
            return 1.8f * celsius + 32;
        }

        public static float ConvertirDeFahrenheitACelsius(float fah)
        {
            return (fah - 32) / 1.8f;
        }

        public static float ConvertirDeCelsiusARankine(float celsius)
        {
            return 1.8f * ConvertirDeCelsiusAKelvin(celsius);
        }

        public static float ConvertirDeRankineACelsius(float rankine)
        {
            return (rankine / 1.8f) - CeroAbsoluto;
        }
    }
}
