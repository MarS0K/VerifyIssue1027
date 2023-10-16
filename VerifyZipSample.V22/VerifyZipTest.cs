namespace VerifyZipSample.V22;

[UsesVerify]
public class VerifyZipTest
{
    [Fact]
    public async Task Test()
    {
        await using var memoryStream = new MemoryStream();

        await ZipSample.Populate(memoryStream);

        await VerifyZip(memoryStream);
    }
}