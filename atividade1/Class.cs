namespace Aula01.Models
{
    public class Variaveis{
        //Tipos implícitos
        //var teste = 10;

        //anotação de tipos
        public int userCount = 10;

        //uma variável pode ser declarada e não inicializada
        public int totalCount;
        

        //CONSTANTES
        //para declarar uma constante utilizamos a palavra chave CONST
        //no entando, a CONST deve ser inicializada quando declarada
        public const int interestRate = 10;


        //o método construtor é invocado na instanciação do objeto por meio da palavra reservada new
        //por regra, o construtor sempre tem o mesmo nome da classe
        public Variaveis(){
            totalCount = 0;

            //tipo implicito
            //a palavra chave var se encarrega de definir o tipo da variavel na instrução de atribuição
            var signalStrength = 22;
            var companyName = "ACME";
        }

        public byte minByte = 0;
        public byte maxByte = 255;

        public sbyte minSbyte = -128;
        public sbyte maxSbyte = 127;

        public short minShort = -32768;
        public short maxShort = 32767;

        public ushort minUshort = 0;
        public ushort maxUshort = 65535;

        public int minInt = -2147483648;
        public int maxInt = 2147483647;

        public uint minUint = 0;
        public uint maxUint = 4294967295;

        public long minLong = -9223372036854775808;
        public long maxLong = 9223372036854775807;

        public ulong minUlong = 0;
        public ulong maxUlong = 18446744073709551615;


    }
}




