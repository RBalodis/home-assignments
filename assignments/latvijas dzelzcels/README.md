## Atlases uzdevumi


## 1.jautājums:

Vilciena sastāvs – vilciena numurs, atiešanas laiks, atiešanas stacija, pienākšanas stacija.
Vilcienā varbūt vairāki vagoni.
Vagonā var tik pārvadāti vairāki kravu veidi vai vairāki konteineri.
Konteinerā varbūt tikai viena krava.
Vagonam ir 8-zīmju numurs, kas rakstīts uz viņa un kārtas numurs vilciena sastāvā.
Konteineram ir 9-zīmju numurs.
Kravas veidiem ir 5-zīmju kods un svars.
### Kāda būs labākā datubāzes struktūra, lai glabātu šo informāciju?

---
## 2.jautājums:

Uzrakstīt SQL pieprasījumu, kurš izdos statistiku, izmantojot grupēšanu, pēc vagona
modeļiem (VAGON.MODEL) un īpašnieka kods (VAG_OPER.KOD_SOB), kur vagona veids
(VAG_OPER.ROD_VAG_OSN) vienāds ar 70 un dislokācijas ceļš (VAG_OPER.DOR_DIS)
būs 9.

SQL pieprasījumam jāizdod:
1) Vagonu skaits
2) Privāto vagonu skaits (VAG_OPER.PR_SOB, 1 = privātais, 0 = nav)
3) Nekrauto vagonu skaitu (VAG_OPER.PPV_GRUJ, 1 = krauts, 0 = nav);
  

| VAG_OPER    |               |
|-------------|:-------------:|
| OPER_ID     |    INTEGER    |
| NOM_VAG     | CHARACTER(12) |
| DOR_RASCH   | CHARACTER(2)  |
| KOP_VMD     |   SMALLINT    |
| STAN_OP     |    INTEGER    |
| DATE_OP     |   TIMESTAMP   |
| DOR_DIS     |   SMALLINT    |
| PR_SOB      | CHARACTER(1)  |
| PPV_GRUJ    | CHARACTER(1)  |
| KOD_SOB     |   SMALLINT    |
| ROD_VAG_OSN |   SMALLINT    |

| VAGON    |               |
|----------|:-------------:|
| NOM_VAG  |    INTEGER    |
| DATE_REG |     DATE      |
| MODEL    | CHARACTER(10) |
| ROD      |   SMALLINT    |

---
## 3.jautājums:
Litra traukā ielika vienu amēbu. Pēc vienas minūtes amēba sadalījās uz divām (tāda pati pēc
izmēra kā pirmā). Vēl pēc minūtes katra amēba sadalījās vēl divās u.t.t.
Precīzi pēc stundas trauks būs pilnībā aizpildīts.
### Cik ātri aizpildīsies trauks, ja sākumā ielikt nevis vienu amēbu, bet divas?