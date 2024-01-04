using NanoidDotNet;

namespace Sentinela.Domain.Identifiers;

public class IdGenerator
{
    public readonly static int ID_SIZE = 15;

    public static string Generate()
      => Nanoid.Generate(size: ID_SIZE);

    public static string GenerateWithSize(int size)
      => Nanoid.Generate(size: size);
}
