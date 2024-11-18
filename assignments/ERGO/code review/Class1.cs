namespace test
{
    public static partial class testClass
    {
	public static decimal? get_stud_annual_insurance_sum(
		decimal? nPromiles,
		decimal? nPromilesBeRiz,
		decimal? nFikMokestis,
		string sSkaiciuotiPagal,
		//decimal? nNominaliSuma,
		//decimal? nBrutoImoka,
		decimal? nBrutoEilineImoka,
		decimal? nMokBudas,
		decimal? nPriemoka,
		decimal? nNuolaida1,
		decimal? nNuolaida2,
		decimal? nNemedicinineRizika1,
		decimal? nNemedicinineRizika2,
		decimal? nTerminuotaRizika1,
		decimal? nTerminuotaRizika2,
		string sPolisoTipas,
		decimal? nPriemokos_versija,
		DateTime? dtPolPradzia,
		int nGarantuotasPeriodas,
		string sTarifas,
		decimal? nTversija,
		decimal? nTrukme,
		decimal? nTrukme1,
		decimal? nVienkartineImoka)
    {
        
 		bool bOk;
		decimal nNld1;
		decimal nNld2;
		decimal nNemedRiz1;
		decimal nNemedRiz2;
		decimal nNemedPromil;
		decimal nNuolaida;
		decimal nMokB;
		decimal nSuma;
		decimal nTermRiz1;
		decimal nTermRiz2;
		decimal nTermPromil;
		decimal nTermTrukme;
		decimal nRizikosSuma;
	
		bOk = nPromiles.HasValue && ( nFikMokestis.HasValue) && !string.IsNullOrEmpty(sSkaiciuotiPagal) && nMokBudas.HasValue && !string.IsNullOrEmpty(sPolisoTipas);
// "A3" case
		if (bOk && nFikMokestis >= 0 && sTarifas.Equals("A3"))
		{
			if (sSkaiciuotiPagal.Equals("Metinę sumą"))
			{
                return null;
			}
			else
                {
				if (!nNuolaida1.HasValue)
				{
                    nNld1 = 1;
				}
				else
				{
					if (nNuolaida1 < 0 || nNuolaida1 > 100)
                    {
					    return null;
					}
					else
					{
						nNld1 = 1 - nNuolaida1.GetValueOrDefault();
					}
				}
				if (!nNuolaida2.HasValue)
				{
					nNld2 = 0;
				}
				else
				{
					if (nNuolaida2 < 0)
					{
						return null;
					}
					else
					{
						nNld2 = nNuolaida2.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
					{
					nNemedRiz1 = 0;
					}
				else
				{
					if (nNemedicinineRizika1 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz1 = nNemedicinineRizika1.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz2 = 0;
				}
				else
				{
					if (nNemedicinineRizika2 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz2 = nNemedicinineRizika2.GetValueOrDefault();
					}
				}


				nNemedPromil = (nNemedRiz1 + nNemedRiz2) * 9.06112M;


				if (sPolisoTipas.Equals("Darbuotojo") || sPolisoTipas.Equals("Šeimos"))
				{
					nNuolaida = nPromilesBeRiz.GetValueOrDefault() * 0.02 M;
				}
				else
				{
					nNuolaida = 0;
				}

				if (sSkaiciuotiPagal.Equals("Bruto eilinę įmoką"))
				{
					if (nBrutoEilineImoka.HasValue)
                       {
						if (nPriemoka == 1)
						{
							nMokB = 1 + mokejimo_budo_priemoka_old(nMokBudas).GetValueOrDefault();
						}
						else
						{
							nMokB = 1;
						}

				      nSuma = Decimal.Round(((nBrutoEilineImoka.GetValueOrDefault() * nMokBudas.GetValueOrDefault() + nNld2) / nNld1 * KoefVersija(dtPolPradzia) - nFikMokestis.GetValueOrDefault()) / nMokB * 1000 / (nPromiles.GetValueOrDefault() - nNuolaida + nNemedPromil), 2);

                       }
					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}

				if (nSuma > 0)
				{
					return nSuma;
				}
				else
				{
					return null;
				}
                }
		}
// "A3_02" case
		if (bOk && nFikMokestis >= 0 && sTarifas.Equals("A3_02"))
		{
            if (sSkaiciuotiPagal.Equals("Metinę sumą"))
			{
				return null;
			}
			else
                {
				if (!nNuolaida1.HasValue)
				{
					nNld1 = 1;
				}
				else
				{
					if (nNuolaida1 < 0 || nNuolaida1 > 100)
					{
						return null;
					}
					else
					{
						nNld1 = 1 - nNuolaida1.GetValueOrDefault();
					}
				}
				if (!nNuolaida2.HasValue)
				{
					nNld2 = 0;
				}
				else
				{
					if (nNuolaida2 < 0)
					{
						return null;
					}
					else
					{
						nNld2 = nNuolaida2.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz1 = 0;
				}
				else
				{
					if (nNemedicinineRizika1 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz1 = nNemedicinineRizika1.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz2 = 0;
				}
				else
				{
					if (nNemedicinineRizika2 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz2 = nNemedicinineRizika2.GetValueOrDefault();
					}
				}

				nNemedPromil = (nNemedRiz1 + nNemedRiz2) * 1.42745M;

				if (sPolisoTipas.Equals("Darbuotojo") || sPolisoTipas.Equals("Šeimos"))
				{
					nNuolaida = nPromilesBeRiz.GetValueOrDefault() * 0.01M;
				}
				else
				{
					nNuolaida = 0;
				}
				if (sSkaiciuotiPagal.Equals("Bruto eilinę įmoką"))
				{
					if (nBrutoEilineImoka.HasValue)
                        {
						if (nPriemoka == 1)
						{
							nMokB = 1 + mokejimo_budo_priemoka(nMokBudas,nPriemokos_versija).GetValueOrDefault();
						}
						else
                         {   
							nMokB = 1;
						 }

						nSuma = Decimal.Round(((nBrutoEilineImoka.GetValueOrDefault() * nMokBudas.GetValueOrDefault() + nNld2) / nNld1 * KoefVersija(dtPolPradzia) - nFikMokestis.GetValueOrDefault()) / nMokB * 1000 / (nPromiles.GetValueOrDefault() - nNuolaida + nNemedPromil), 2);
						 
                        }

					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}
				if (nSuma > 0)
				{
					return nSuma;
				}
				else
				{
					return null;
				}
                }
		}
// "A3_03" case
		if (bOk && nFikMokestis >= 0 && sTarifas.Equals("A3_03"))
            {
			if (sSkaiciuotiPagal.Equals("Metinę sumą"))
			{
				return null;
			}
			else
                {
				if (!nNuolaida1.HasValue)
				{
					nNld1 = 1;
				}
				else
				{
					if (nNuolaida1 < 0 || nNuolaida1 > 100)
					{
						return null;
					}
					else
					{
						nNld1 = 1 - nNuolaida1.GetValueOrDefault();
					}
				}
				if (!nNuolaida2.HasValue)
				{
					nNld2 = 0;
				}
				else
				{
					if (nNuolaida2 < 0)
					{
						return null;
					}
					else
					{
						nNld2 = nNuolaida2.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz1 = 0;
				}
				else
				{
					if (nNemedicinineRizika1 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz1 = nNemedicinineRizika1.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz2 = 0;
				}
				else
				{
					if (nNemedicinineRizika2 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz2 = nNemedicinineRizika2.GetValueOrDefault();
					}
				}

				nNemedPromil = (nNemedRiz1 + nNemedRiz2) * 3.2M;

				if (sPolisoTipas.Equals("Darbuotojo") || sPolisoTipas.Equals("Šeimos"))
				{
					nNuolaida = nPromilesBeRiz.GetValueOrDefault() * 0.18M;
				}
				else
				{
					nNuolaida = 0;
				}
				if (sSkaiciuotiPagal.Equals("Bruto eilinę įmoką"))
				{
					if (nBrutoEilineImoka.HasValue)
                        {
						if (nPriemoka == 1 )
						{
							nMokB = 1 + mokejimo_budo_priemoka(nMokBudas,nPriemokos_versija).GetValueOrDefault();
						}
						else
						{
							nMokB = 1;
						} 

						nSuma = Decimal.Round(((nBrutoEilineImoka.GetValueOrDefault() * nMokBudas.GetValueOrDefault() + nNld2) / nNld1 * KoefVersija(dtPolPradzia) - nFikMokestis.GetValueOrDefault()) / nMokB * 1000 / (nPromiles.GetValueOrDefault() - nNuolaida + nNemedPromil), 2);

                        }
					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}

				if (nSuma > 0)
				{
					return nSuma;
				}
				else
				{
					return null;
				}
                }
			}
// "A3E" case
		if (bOk && nFikMokestis >= 0 && sTarifas.Equals("A3E"))
		{
			if (sSkaiciuotiPagal.Equals("Metinę sumą"))
			{
				return null;
			}
			else
                {
				if (!nNuolaida1.HasValue)
				{
					nNld1 = 1;
				}
				else
				{
					if (nNuolaida1 < 0 ||  nNuolaida1 > 100)
					{
						return null;
					}
					else
					{
						nNld1=1 - nNuolaida1.GetValueOrDefault();
					}
				}
				if (!nNuolaida2.HasValue)
				{
					nNld2 = 0;
				}
				else
				{
					if (nNuolaida2 < 0)
					{
						return null;
					}					
					else
					{
						nNld2 = nNuolaida2.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz1 = 0;
				}
				else
				{
					if (nNemedicinineRizika1 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz1=nNemedicinineRizika1.GetValueOrDefault();
					}
				}
				if (!nNemedicinineRizika1.HasValue)
				{
					nNemedRiz2 = 0;
				}
				else
				{
					if (nNemedicinineRizika2 < 0)
					{
						return null;
					}
					else
					{
						nNemedRiz2=nNemedicinineRizika2.GetValueOrDefault();
					}
				}

				nNemedPromil=(nNemedRiz1 + nNemedRiz2) * 0.6435M;

				if (!nTerminuotaRizika1.HasValue)
				{
					nTermRiz1 = 0;
				}
				else
				{
					if (nTerminuotaRizika1 < 0)
					{
						return null;
					}
					else
					{
						nTermRiz1 = nTerminuotaRizika1.GetValueOrDefault();
					}
				}
				if (!nTerminuotaRizika2.HasValue)
				{
					nTermRiz2 = 0;
				}
				else
				{
					if (nTerminuotaRizika2 < 0)
					{
						return null;
					}
					else
					{
						nTermRiz2 = nTerminuotaRizika2.GetValueOrDefault();
					}
				}

				nTermPromil=(nTermRiz1 + nTermRiz2) * 5.68714M;

				if (!nTerminuotaRizika1.HasValue &&  !nTerminuotaRizika2.HasValue)
				{
					nTermTrukme = 0;
				}
				else
				{
					if (nTrukme1.HasValue)
					{
						if (nTrukme1 > 0 && nTrukme1 <= 100)
						{
							nTermTrukme = nTrukme1.GetValueOrDefault();
						}
						else
						{
							return null;
						}
					}
					else
					{
						return null;
					}
				}
				if (sPolisoTipas.Equals("Darbuotojo") || sPolisoTipas.Equals("Šeimos"))
				{
					nNuolaida = nPromilesBeRiz.GetValueOrDefault() * 0.38M;
				}
				else
				{
					nNuolaida = 0;
				}

				nRizikosSuma = 1 - nPromilesBeRiz.GetValueOrDefault() / 6.9852M / 1000M;

				if (nRizikosSuma < 0)
				{
					nRizikosSuma = 0;
				}
				if (sSkaiciuotiPagal.Equals("Vienkartinę įmoką"))
				{
					if (nVienkartineImoka.HasValue)
					{
						nSuma = Decimal.Round(((nVienkartineImoka.GetValueOrDefault() + nNld2) / nNld1 * KoefVersija(dtPolPradzia) - nFikMokestis.GetValueOrDefault()) * 1000 / (nPromiles.GetValueOrDefault() - nNuolaida + nRizikosSuma * (nNemedPromil * nTrukme.GetValueOrDefault() + nTermPromil * nTermTrukme)), 2);
					}
					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}
				if (nSuma > 0)
				{
					return nSuma;
				}
				else
				{
					return null;
				}
                }
		}
		else
		{
			return null;
		}

    }

	private static decimal? mokejimo_budo_priemoka(decimal? nMokBudas, decimal? nPriemokosVersija)
	{
		return 1m;
	}

	private static int KoefVersija(DateTime? dtPolPradzia)
	{
		return 1;
	}

	private static decimal? mokejimo_budo_priemoka_old(decimal? nMokBudas)
	{
		return 1M;
	}

	//end of class

	}	
	
}