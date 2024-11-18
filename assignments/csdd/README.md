Uzdevums: izveidot vizuālu web lapu, kurā tiek parādīti transportlīdzekļi (TL), kas norīkoti tehniskās apskates (TA) laukumā, un to sadalījums pa līnijām.

 

Pielikumā datu fails db.json, kas sastāv no transportlīdzekļu saraksta, kas norīkoti uz TA līnijām apskašu laukumā.

Viena ieraksta rinda sastāv no 5 laukiem, kur:

id - Ieraksta identifikators;                            

numurs - norīkotās līnijas numurs;

rn - transportlīdzekļa numurs;

datums - datums, kad norīkots līnijā;

s_datums - datums, kad pabeigta tehniskā apskate un TL ir izbraucis no TA laukuma.

 

Norādot datumu un laiku, jāatfiltrē tie ieraksti, kas ir pa vidu starp lauka datums un s-datums vērtībām.

Ja lauks s_datums ir null, tad tāds transportlīdzeklis vēl ir TA laukumā, jāuzskata, ka vērtība ir lielāka par norādīto datumu un laiku.

Vienā līnijā esošie TL jāsakārto pieaugoši pēc ID vērtības.

Noklikšķinot uz transportlīdzekļa numura, jāparāda paziņojums: "Vai izņemt TL "numurs" no līnijas?", apstiprinājuma gadijumā konkrētais TL "jāizņem" no saraksta un jāpārlādē dati.

Izņemt var tikai tādu TL, kam lauks s_datums ir null.

Tā kā dati ir statiski, tad izņemšana var būt virtuāla, pietiek ar paziņojumu Snackbar vai tamlīdzīgu vizuālu apstiprinājumu, ka TL izņemts.

Apskašu līniju skaits ir 12. Maksimālais līnijas garums ir 14.

Datu atjaunošanai jānotiek bez lapas pārlādes. Pogu, datumu un laika ievade ir brīvi interpretējama. Vizuālās stils arī nav strikti definēts, var izpausties.

Uzdevuma izpildei vēlamā tehnoloģija ir React.Js, Angular(8+), vai Vue.Js.

Izpildītu uzdevumu var publicēt Github.com

 

Vizuāls paraugs, kā tam būtu strukturāli jāizskatās. (image001.png)

