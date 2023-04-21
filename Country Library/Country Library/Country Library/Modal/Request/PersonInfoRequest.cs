namespace CountryLibrary.Modal.Request
{
    public class PersonInfoRequest
    {
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public double BMICalculator => (Weight / Math.Pow(Height, 2));
    }
}