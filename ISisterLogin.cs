using MetaDataLibrary.SisterLogIn;

namespace RepositoryLibrary.ISisterLogin
{
    public interface ISisterLogin
    {
        List<SisterLoginViewModel> GetSisters();
        SisterLoginViewModel GetSisterLogIn(string password, int SiSisterIdNo);
    }//interface...
}
