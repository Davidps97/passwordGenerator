using Microsoft.AspNetCore.Mvc;
using System;

namespace PasswordGeneratorApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PasswordController : ControllerBase
  {
    // GET: api/password/generate?length=12&includeNumbers=true&includeSymbols=true
    [HttpGet("generate")]
    public IActionResult GeneratePassword(int length = 12, bool includeNumbers = true, bool includeSymbols = true)
    {
      const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
      const string numbers = "0123456789";
      const string symbols = "!@#$%^&*()_+<>?";

      Random random = new Random();
      int passwordLength = random.Next(8, 17);

      char[] password = new char[passwordLength];

      password[0] = letters[random.Next(26, 52)];
      password[1] = symbols[random.Next(symbols.Length)];
      password[2] = numbers[random.Next(numbers.Length)];
      password[3] = numbers[random.Next(numbers.Length)];

      string validChars = letters + numbers + symbols;
      for (int i = 4; i < passwordLength; i++)
      {
        password[i] = validChars[random.Next(validChars.Length)];
      }

      password = password.OrderBy(x => random.Next()).ToArray();

      string generatedPassword = new string(password);

      return Ok(new { password = generatedPassword });
    }

  }
}
