using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Demo.CS;

namespace UWP_Demo.Service
{
    interface IFileService
    {
        Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential);

        Task<MemberCredential> ReadMemberCredentialFromFile();
        void SignOutByDeleteToken();
    }
}
