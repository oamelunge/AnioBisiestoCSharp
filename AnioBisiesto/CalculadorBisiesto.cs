namespace AnioBisiesto
{
    public class CalculadorBisiesto
    {
        private static int anio;

        public CalculadorBisiesto(int _anio)
        {
            anio = _anio;
        }

        public bool es_bisiesto()
        {
            return EsAnioBisiestoTipico() && !EsAnioComunNoTipico();
        }

        private static bool EsAnioBisiestoTipico()
        {
            CalculadorBisiesto.anio = anio;
            return CalculadorBisiesto.anio%4 == 0;
        }

        private static bool EsAnioComunNoTipico()
        {
            return anio%100==0 && anio%400 != 0;
        }
    }
}