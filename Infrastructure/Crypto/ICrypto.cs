using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Crypto
{
    public interface ICrypto
    {
        string Hash(string value);
        bool VerifyHash(string value, string hash);
        string Hash(string value, string key);
        bool VerifyHash(string value, string key, string hash);
        string GenerateNumericCode(int digits);
        string GenerateSalt();
        string HashPassword(string password, int iterations);
        bool VerifyHashedPassword(string hashedPassword, string password);
    }
}
