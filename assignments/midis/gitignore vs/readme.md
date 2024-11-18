### Priekšvārds
---
Daļēji, bet kvalitātīvi izpildīts uzdevums tiks uzskatīts par veiksmīgu.
Pie izpildītā darba novērtēšanas tiks ņemti vērā sekojoši kritēriji:
- Izpratne par uzdevumumu kopumā;
- Spēja saprast biznesa prasības;
- Loģiskā spriestspēja;
- Komunikācijas prasmes;
- Darba pašorganizācija;
- Koda realizācija;
- Izpratne par pielietojamajām tehnoloģijām;
- Spēja pašmācības ceļā apgūt jaunu informāciju. 
### Lietotājstāsts
---
Es kā pasūtītājs vēlos WEB aplikāciju, kura spēj augšupielādēt norādītā formāta datnes ar 
maksimāli pieļaujamo datnes izmēru ne lielāku par 50Mb. Jānodoršina iespēja, 
katrai augšupielādētajai datnei norādīt papildus metadatus: datnes nosaukums, komentāri.
Aplikācijai jānodrošina 2 lietotāju lomas: 
- Administrators – pilna piekļuve visai funkcionalitātei;
- Lietotājs – var augšupielādēt datnes, tās apkskatīt, dzēst;
### Uzdevuma norādes 
---
1. Sagatavot publisku GIT repozitoriju, kur tiks augšupielādēts kods un dokumenti;
- Izmantojam GitHub publiska repozitprija reģistrācijai
- Palīdzība, kā GitHub nokonfigurēt, lai tas būtu publiski pieejams 
https://help.github.com/en/github/administering-a-repository/setting-repository-visibility
3. Katram uzdevumam (zemāk aprakstā Aplikācijas izstrāde) izvedot apakšuzdevumus un to sarakstu Word dokumenta veidā izvietot repozitorijā.
Pa e-pastu noinformēt, ka dokuments ar veicamo uzdevumu sarakstu ir sastādīts;
4. Katru dienu, laiks kurš tiek veltīts prakses iziešanai vai uzdevuma izstrādei, atzīmēt tabulas veida dienasgrāmatā (zemāk piemērs).
Dienasgrāmatu aizpildam un glabājam tajā pašā repozitorijā. Kolonnā Piezīmes, īsi,
bet kodolīgi norādam kādas problēmas tika risinātas, kāda uzdevuma, algoritma izstrāde tika veikta. 
### Aplikācijas Izstrāde
---
Veidojot Web aplikāciju, lietotāja saskarnes realizācijas tehnoloģiju, satvaru (framework), students/pretendents var brīvi izvēlēties pēc savām zināšanām un pieredzes.
Te nav būtisks vizuālais izskats, bet gan funkcionālais, tāpēc necenšamies noformēt visu skaisti un korekti!
Implementējot servera puses realizāciju (Web API), nepieciešams izmantot ASP.NET Core 3.0 ar  Entity Framework Core, DB izmantojam MS SQL serveri.
### Implementācijas uzdevumi
---
1. Iepazīties ar zemāk norādītājiem uzdevumiem un veikt DB puses izstrādi. 
Pēc brīvas izvēles – izstrādāt un sagatavot SQL scriptu DB tabulu ģenerācijai vai arī izveidot DB migrācijas projektu.
Ar DB migrācijas projekta izveidi var nedaudz iepazīties šajā dokumentācijā 
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
2. Nodrošināt, lai lietotāji ar dažādām lomām (administrators un lietotājs) spētu autorizēties un  autentificēties. Kā piemēru implementācijai var izmantot šo resursu 
https://jasonwatmore.com/post/2019/10/16/aspnet-core-3-role-based-authorization-tutorial-with-example-api;
3. Norealizēt iestatījumu rediģēšanas, pievienošanas funkcionalitāti (administratora loma):
- Administratoram jāspēj DB saglabāt šāda veida iestatījumus:
- Augšupielādējamo datņu atļautos paplašinājumu(file extensions) sarakstu;
- Maksimāli atļauto datnes izmēru;
- Ja augšupielādējamā datne ir attēls, tad minimāli atļautos bildes izmērus (piem., 200px * 200px);
- Maksimāli atļauto bildes izmēru(ja bilde būs lielāka, tad veikt bildes mērogošanu līdz atļautajam izmēram).
4. Norealizēt augšupielādes funkcionalitāti (gan administrators, gan lietotājs):
- Augšupielādējot datni, lietotājam jāvar norādīt datnes nosaukumu un komentārus;
- Augšupielādēt var tikai tās datnes, kuras atbilst norādītajiem iestatījumiem, pretējā gadījumā izvadīt paziņojumu par kļūdu;
- Visām augšupielādējamām datnēm jāglabājas Microsoft Azure Blob Storage. 
Šeit https://community.dynamics.com/365/b/heralddyncrm/posts/upload-and-download-files-in-azure-blob-using-c atrodams īss apraksts,
kā izveidot un kā pieslēgt Azure lietotāja kontu.
.NET Core risinājuma apraksts atrodams https://dotnetcoretutorials.com/2017/06/17/using-azure-blob-storage-net-core/
- Realizēt attēla mērogošanu līdz atļautajam izmēram (no iestatījumu tabulas). 
Mērogošanai jāizmanto bibliotēka https://github.com/dlemstra/Magick.NET.
- Augšupielādētās datnes jāattēlo sarakstā ar infinity scroll iespēju;
- Jānodrošina iespēju dzēst datnes;