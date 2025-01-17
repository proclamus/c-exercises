    public static int birthdayCakeCandles(List<int> candles)
    {
        int tallest = 0;
        int countTallest = 0;
        foreach(int candle in candles)
        {
            if (candle > tallest)
            {
                tallest = candle;
            }
        }
        
        foreach(int candle in candles)
        {
            if(candle == tallest)
            {
                countTallest++;
            }
        }
        return countTallest;
        
        
    }

//Versão melhorada

public static int BirthdayCakeCandles(List<int> candles)
{
    int tallest = candles.Max(); // Encontra a vela mais alta
    return candles.FindAll(candle => candle == tallest).Count; // Conta as velas com a altura máxima
}
