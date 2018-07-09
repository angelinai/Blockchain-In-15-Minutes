namespace BlockchainIn15Minutes.Interfaces
{
    public interface IHasherService
    {
        byte[] ComputeSha256(byte[] input);

        byte[] ComputeSha512(byte[] input);
    }
}