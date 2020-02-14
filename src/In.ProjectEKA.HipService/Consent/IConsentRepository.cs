namespace In.ProjectEKA.HipService.Consent
{
    using System.Threading.Tasks;
    using Model;

    public interface IConsentRepository
    {
        public Task AddAsync(Consent consent);
    }
}