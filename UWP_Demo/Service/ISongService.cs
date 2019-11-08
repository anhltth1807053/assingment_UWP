using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Demo.CS;

namespace UWP_Demo.Service
{
    interface ISongService
    {
        Song CreateSong(MemberCredential memberCredential, Song song);
        List<Song> GetAllSong(MemberCredential memberCredential);
        List<Song> GetMineSongs(MemberCredential memberCredential);
    }
}
