- Uzdevumā ir speciāli noklusēta daļa no informācijas. Mērķis ir pārbaudīt, kā lietotājam tiks piedāvāts optimāls risinājums, vai kā tiks atrasts risinājums nepilnās informācijas apstākļos. Grafikai nav izšķirošās nozīmes, bet informācijai jābūt attēloti tā, lai ar to būtu viegli strādāt.


 - Izpildīto uzdevumu ir jāielādē vietnē GitHub un obligāti ir jāizveido readme fails ar:
1. Aprakstu, kā var palaist gatavu uzdevumu
2. Īsu izveidotās sistēmas aprakstu
- Ir svarīgi realizēt sistēmu, izmantojot šādas tehnoloģijas:
1. Laravel v9
2. PHP 8.0
3. MySQL
- Pārbaudei projekts tiks palaists uz XAMPP 8.0.19

- Vispārējā informācija par sistēmu
Ir datubāze kas satur informāciju par kompānijas darbību. Kompānija piegādā preces klientiem, katram klientam var būt vairākas piegādes vietas. Piegādes uzdevums sastāv no vispārējās informācijas (Adrese, tips, status un tml.) un no piegādes rindām (prece, daudzums, cena un tml.). Piegādes tiek sagrupētas maršrutos, vienā maršrutā vienmēr ir viens šoferis un brauciens notiek konkrētā datumā.

- Uzdevums
•	izveidot interneta vietni, kas sastāvēs no dažām lapām. Katrā lapā jābūt navigācija izvēlne, caur kuru varēs nokļūt uz visām lapām.
•	Izveidot un aizpildīt datubāzi, saskaņā ar tabulu pielikumā
Svarīgi: prognozētais datu apjoms ir liels, līdz ar to ir nepieciešams minimizēt SQL pieprasījumus, kā arī maksimāli noslogot SQL serveru, nevis pašu programmu, SQL optimizācija arī tiks uzskatīta par priekšrocību.


 - Lapas:
1.	Klientu saraksts
Lapai jābūt sadalītai uz divām daļām. Kreisajā pusē jāparāda saraksts ar visiem klientiem (klienta nosaukumi). Katrā rindā jābūt divas pogas “Parādīt adreses” un “Atvērt piegādes”. Labajā pusē jābūt info lauks, kur parādīsies informācija par viena izvēlētā klienta adresēm. Šim laukam ir jāatjaunojas dinamiski, nepārlādējot lapu, pie pogas “Parādīt adreses” uzspiešanas.
Poga “Atvērt piegādes” atver lapu “Klientu Piegādes”


2.    Klientu piegādes
Lapai jābūt sadalītai uz divām daļām. Augšējā lapas pusē jābūt info par izvēlēto klientu (lapu nevar atvērt bez norādes uz konkrētu klientu). Apakšēja lapas sadaļa ir jābūt tabula ar piegādes uzdevumu sarakstu. Tabulā jābūt norādītām kolonnām:
-	Piegādes adrese
-	Piegādes datums
-	Preču summa
-	Piegādes status
3.	Atskaite “Pasūtījumu tipi”
Lapai jābūt tabula, kas parādīs tikai tos klientus, kuriem bija dažādi piegādes tipi uz vienu adresi, gan šķidrās preces, gan cietās.
Tabulā jābūt norādītām kolonnām:
- Klienta nosaukums
- Piegādes adrese
4. Atskaite “Pēdējā piegāde”
Lapai jābūt saraksts ar pēdējām piegādēm
Tabulā jābūt norādītām kolonnām:
- Klienta nosaukums
- Piegādes adrese
- Prece
- Preces summa
5. Atskaite “Neaktīvie klienti”
Lapai jābūt saraksts ar klientiem, kuriem nekad netika piegādāta šķidrā prece.
•	Klienta nosaukums
•	Piegādes adrese

Datubāzes apraksts

|       | Tips |              |
|-------|------|--------------|
|Clients|      |Klientu tabula|
|•ID  |  Int |
|•Name|String|
|•Phone|String|
|•Email|String|
| |
|Addresses| |Adrešu tabula
|•	ID|Int
|•	Title|String
|•	ClientID|Int
| |
|Deliveries| |Piegādes tabula
|•	ID|Int
|•	RouteId|Int
|•	AddressID|Int
|•	Type|Int|Pasūtījuma tips 1 – šķidrā prece 2 – cietā prece Katru preces veidu var piegādāt tikai noteiktais transporta tips, mašīna ar cisternu, vai parastā kravas mašīna.|
|•	Status|Int|Pasūtījuma statuss 1 – nav izpildīts 2 – ir izpildīts 3 – atcelts |
| |
|DeliveryLines| |Pasūtījuma rindas (detaļas)|
|•	ID|Int
|•	DeliveryID|Int
|•	Item|String
|•	Price|Float
|•	QTY|Float
| |
|Routes| |Maršrutu tabula
|•	ID|Int
|•	Date|Date
|•	CarNumber|String
|•	Status|Int|Maršruta status 1 – Izveidots 2 – Ieplānots 3 – Slēgts
|•	DriverName|String


