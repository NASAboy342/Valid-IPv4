using CountryLibrary.Modal.Request;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PracticeController : ControllerBase
    {
        [HttpPost]
        [Route("ipv4check")]
        public bool IPvalidation(Ipv4Request request)
        {
            string[] ipPart = request.Ip.Split('.');

            if (ipPart.Length != 4)//check if 4 part
            {
                return false;
            }
            for (int i = 0; i <= ipPart.Length; i++)
            {
                try//check if invalid charactor
                {
                    //ipPart[i].Replace(".", string.Empty);
                    int intPart = Convert.ToInt32(ipPart[i]);
                    var isBetween0and255 = intPart < 0 || intPart > 255;
                    var isStartWith0 = ipPart[i].Length > 1 && ipPart[i][0].Equals('0');
                    if (isBetween0and255 || isStartWith0)
                        return false;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            return true;
        }

        

        [HttpPost]
        [Route("bmi")]
        public string GetStandardByGender(PersonInfoRequest request)
        {
            double bmi = request.BMICalculator;
            string g = request.Gender;
            const int FemaleStandard = 22;
            const int MaleStandard = 24;
            if (g.Equals("Female") || g.Equals("F"))
            {
                if (bmi < FemaleStandard)
                {
                    return "Too thin";
                }
                else if (bmi > FemaleStandard)
                {
                    return "Too fat";
                }
                else
                {
                    return "Normal";
                }
            }
            else if (g.Equals("Male") || g.Equals("M"))
            {
                if (bmi < MaleStandard)
                {
                    return "Too thin";
                }
                else if (bmi > MaleStandard)
                {
                    return "Too fat";
                }
                else
                {
                    return "Normal";
                }
            }
            else { return ""; }
        }
    }
}