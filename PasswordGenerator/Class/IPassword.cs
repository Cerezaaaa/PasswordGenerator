using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Class
{
    public interface IPassword
    {
        IPassword IncludeLowercase();
        IPassword IncludeUppercase();
        IPassword IncludeNumeric();
        IPassword IncludeSpecial();
        IPassword IncludeSpecial(string specialCharactersToInclude);
        IPassword LengthRequired(int passwordLength);
        string Next();
        IEnumerable<string> NextGroup(int numberOfPasswordsToGenerate);
    }
}
