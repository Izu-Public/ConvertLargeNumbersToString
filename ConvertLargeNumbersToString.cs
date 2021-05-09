public static class yourclassname
{
	// Convert large numbers to strings such as "12.3K", "12.3M" / "1.2千", "12.3万". 
	//	@param	aIsJapanese			Japanese or English. 
	//	@param	aNumber				A target number. 
	//	@param	aIsEnableDecimals	If true, decimals will be appended. 
	public static string ConvertLargeNumbersToString( bool aIsJapanese, float aNumber, bool aIsEnableDecimals )
	{
		if( aNumber < 1000 )
		{
			// No chanhes 
			return aNumber.ToString();
		}
		if( aIsJapanese == false )
		{// English 
			if( aNumber < 1000000 )
			{// 1K 
				var v = aNumber / 1000.0f;
				return aIsEnableDecimals?
					String.Format( "{0:#.#}K", v ):
					( (int)v ).ToString() + "K";
			}
			else
			{// 1M 
				var v = aNumber / 1000000.0f;
				return aIsEnableDecimals?
					String.Format( "{0:#.#}M", v ):
					( (int)v ).ToString() + "M";
			}
		}
		else
		{// Japanese 
			var k = "千";
			var m = "万";
			if( aNumber < 10000 )
			{// 1K 
				var v = aNumber / 1000.0f;
				return aIsEnableDecimals?
					String.Format( "{0:#.#}", v ) + k:
					( (int)v ).ToString() + m;
			}
			else
			{// 10K 
				var v = aNumber / 10000.0f;
				return aIsEnableDecimals?
					String.Format( "{0:#.#}", v ) + m:
					( (int)v ).ToString() + m;
			}
		}
	}
}
