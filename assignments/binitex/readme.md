Testa uzdevuma apraksts

Šis uzdevums ir sagatavots dažādiem pretendentu prasmju līmeņiem. Jebkurš rezultšts tiks izvērtēts.
Mēs esam izvēlējušies uzdevumu, saistītu ar COVID19 statistikas attēlošanu. Projekts jāizpilda
izmantojot React un TypeScript (drīkst izmantot arī JavaScript). Gatavu rezultātu augšupielādējiet
Github vai Bitbucket repozitorijā ar publisku piekļuvi. Gadījumā, ja kādu iemeslu dēļ jums tas nav
izdevies, atsūtiet arhīvu ar kodu.

Jārealizē šāda funkcionalitāte:

1. Datu ieguve
2. Datu attēlošana (tabula, grafiks)
3. Manipulācijas ar datiem - agregācija un filtrācija
4. Izstrādāt aplikācijas dizainu. Drīkst izmantot gatavas CSS vai arī vidžetu bibliotēkas

Datu saņemšana

Aplikācijai jāiegūst statistikas dati no atklātā API:
https://opendata.ecdc.europa.eu/covid19/casedistribution/json/

Datu attēlošana

Aplikācijai jābūt bāzes interfeisam
Kolonnas: Valsts, Gadījumu skaits, Nāves gadījumu skaits, Gadījumu skaits kopā (ignorē datuma
filtru), Nāves gadījumu kopā (ignorē datuma filtru). Gadījumu skaits uz 1000 iedzīvotājiem, Nāves
gadījumu skaits uz 1000 iedzīvotājiem

Funkcionalitāte

1. Var izvēlēties laika periodu, izmantojot datepicker (datumu atlasītājs ar kalendāru, kurā var
izvēlēties datumus no/līdz).
a. Pēc noklusējuma ir izvēlēts pilns periods (minimālais un maksimālais datums no
statistikas)
2. Lietotājs var pārslēgties starp diviem datu attēlošanas veidiem - tabula un grafiks.
a. To var realizēt ar cilnēm (tabs) Tabula un Grafiks, vai arī izmantojot dropdown list.
3. Tabulas režīmā jāattēlo tabula ar 7 kolonnām, kā norādīts attēlā.
a. Datiem tabulā jābūt sakārtotiem (pēc noklusējuma - pēc valsts nosaukuma alfabētiskā
sēcībā).
b. Var pievienot iespēju kārtot datus, nospežot kolonnas virsrakstu
c. Var arī pievienot datu sadalīšanu pa lappusēs (paging), līdz 20 rindām katrā lapā.
4. Virs tabulas atrodas divi filtri - meklēšanai pēc valsts nosaukuma vai arī pēc kāda cita
nosacījuma.
a. Pēc noklusējuma abi filtri ir tukši.
b. Filtrācija pēc valsts nosaukuma - teksta ievades lauks (textbox).
c. Citu lauku filtrācija realizēta izmantojot dropdown ar iespējamām vērtībām (piem.
gadījumu skaits, nāves gadījumu skaits) un diviem teksta ievades laukiem, kur var
norādīt minimālu un maksimālu vērtību.
d. Tiklīdz ir ievadītas kādas filtra vērtības, jāatjauno dati tabulā.
5. Virs tabulas jābūt filtru attīrīšanas pogai. Kad tā ir nospiesta, jānotīra visi filtri, kā arī jāatjauno
dati tabulā
6. Ja pēc filtra kritērijiem sistēma nespēja atrast datus, tad tabulā rindu vietā jāizvada teksts “Pēc
jūsu kritērijiem nekas netika atrasts”
7. Pārsledzoties uz Grafika režīmu, tabulas un filtru vietā jāparāda grafiks ar divām līknēm.
a. X līkne nozīmē izvēlēto periodu, Y līkne attēlo gadījumu skaitu. Grafikam datu iegūšanai
jāizmanto tie paši filtri, kas ir norādīti cilmē ar tabulu


Papildus funcionalitāte


Zemāk ir papildus funkciju saraksts tiem, kam iepriekšējais saraksts bija par vieglu 😎

● Filtru vērtības validācija

○ Datumu atlasītājā (datepicker) jābūt minimālam un maksimālam iespējamiem datumiem
saskaņā ar iegūtiem statistikas datiem (piem. nedrīkst izvēlēties 2018. gadu, par kuru
nav statistikas)

○ Mainīt min/max vērtību filtra fonu uz sarkanu, ja tajā tika ievadīts teksts, kurš nav cipars.

● Filtrācijas procesa uzlabošana

○ Valsts nosaukumu filtru realizēt dropdown veidā. Ja nav izvēlēta neviena valsts - rādīt
summārus datus pa visām valstīm

○ Pie datumu filtra novietot pogu “Attēlot visu laiku datus”, kura maina datumu filtru
ievadītās vērtības uz vērtībām pēc noklusējuma
■ šai pogai jāparādās tikai ja dati filtrā atšķiras no noklusējuma vērtībām

● Iespēja norādīt cik tabulas rindas jāatēlo vienā lapā (pager size)

● Papildus kolonnas tabulā

○ vidējais saslimstības un nāves gadījumu skaits dienā izvēlētajā periodā

○ maksimālais saslimstības un nāves gadījumu skaits dienā izvēlētajā periodā

● Realizēt responsive dizainu (lai labi izskatās gan datorā, gan mobīlā ierīcē)


Padomi 👆


Zemāk ir daži padomi un rekomendācijas, kas palīdzēs uzdevuma izpildē:

● React palīdz ātri izveidot līdzīgas aplikācijas, tāpēc, ja agrāk nebija iespējas ar to strādāt, tad
apmācības video palīdzēs iegūt pamatzināšanas. Piemēram:
https://reactjs.org/tutorial/tutorial.html

● Nemēģiniet izgudrot to, kas jau eksistē, un droši izmantojiet gatavus komponentus standarta
elementiem. Keywords: datagrid, datepicker, charts и т.д.

● Bootstrap ļauj veidot web lapas, kuras pielāgojas dažādiem ekrāna izmēriem.

● Create React App ļauj izveidot aplikācijas bāzi ar TypeScript atbalstu

● Par Git un Github var izlasīt, šeit: https://bit.ly/3cD0C9H

● Iespējams, izstrādes laikā jūs redzēsiet kļūdu: “Access to fetch at
'https://opendata.ecdc.europa.eu/covid19/casedistribution/json/' from origin
'http://localhost:3000' has been blocked by CORS policy: No 'Access-Control-Allow-Origin'
header is present on the requested resource.” Problēmas risinājumam jāizpēta, kas ir CORS.
Materiāli ir pieejami šeit: https://mydaytodo.com/cors-issue-and-nodejs-proxy
