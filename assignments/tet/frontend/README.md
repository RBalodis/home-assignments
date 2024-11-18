## Praktiskais uzdevums
Izveidot sarakstu ar bildēm izmantojot Continuous Scrolling sistēmu. Uzdevuma veidošanai izmantot Rick and
Morty seriāla tēlu API. Lapas viewportā izvadīt tēlus, lai noklātu visu ekrāna izmēru

Nonākot lapas apakšdaļā, jāpieprasa nākamās lapas dati page=+1 un tie jāattēlo.

Lietojums jāizstrādā izmantojot HTML5, SCSS un Angular ietvaru. Lapai jābūt responsīvai.
UI bibliotēku izmantošana pēc jūsu vēlmēm, priekšrocību dodam Bootstrap.
Tiks papildus novērtēts, ja:
• Tiks izmantota kāda state management bibliotēka datu lokālai saglabāšanai;
• Uzrakstīti gan Unit, gan e2e testi.

## Uzdevums

Izveidot SPA (Single Page Application) lietojumu, kas ielasa datus no Rick and Morty API
https://rickandmortyapi.com/documentation/#rest
un attēlo tos saraksta veidā. Lietojums jāizstrādā izmantojot HTML5, SCSS un Angular ietvaru (12. vai 13.
versiju). Ir atļauts izmantot UI bibliotēkas, piemēram, Bootstrap, Material u.c.

## Pamatuzdevums

Lietojumam jābūt divām sadaļām:

1. “Characters” – redzams saraksts ar tēliem no seriāla. Sarakstā jābūt redzamam tēla vārdam
   “Name”, attēlam, dzimumam “Gender” un epizožu skaitam “Episode count”, kurās tas piedalījies.
   Lietotājs var filtrēt tēlus pēc “Name” (ar input) un/vai dzimuma “Gender” (ar dropdown);
2. “Locations” – redzams saraksts ar vietām no seriāla. Sarakstā jābūt redzamam vietas nosaukumam
   “Name”, dimensijai “Dimension” un iedzīvotāju skaitam “Residents”. Lietotājs var filtrēt vietas pēc
   “Name” (ar input) un/vai “Dimension” (ar input)

## Papildus uzdevumi

1. Integrēt pagination sarakstu sadaļās;
2. Izveidot abām sadaļām (gan “Locations”, gan “Characters”) papildus relatīvos PATH, kur, atdalot ar
   komatu, var norādīt konkrētus ID, piemēram, “/characters/1,2,3” un atverot šo PATH, tēlu sarakstā tiks
   atrādīti tikai 3 tēli, kuru ID attiecīgi ir 1,2,3;
3. Papildināt “Characters” saraksta sadaļu ar tēla “Origin” (izcelsmes vietu) un “Location” (atrašanās
   vietu). Uzklikšķinot uz konkrētās vietas nosaukuma, tiek attēlota informācija par to, vai nu notiekot
   pāradresācijai uz “Location” saraksta sadaļu (kur redzama tikai šī konkrētā vieta), vai arī atveras
   modālais dialogs (modals);
4. "Locations" saraksta sadaļā zem “Residents” iedzīvotāju skaita vietā ievietot sarakstu ar iedzīvotāju
   (tēlu) vārdiem. Uzklikšķinot uz konkrētā tēla, tiek attēlota informācija par to, vai nu notiekot
   pāradresācijai uz “Characters” saraksta sadaļu (kur redzams tikai šis konkrētais tēls), vai arī atveras
   modālais dialogs (modals);
5. Izveidot trešo sadaļu “Episodes” – redzams saraksts ar seriāla epizodēm. Sarakstā jābūt redzamam
   epizodes nosaukumam “Title”, izlaišanas datumam “Air date”, epizodes numuram “Episode” un tēlu
   skaitam “Characters”, kas piedalās epizodē. Lietotājs var filtrēt epizodes pēc “Title” (ar input);
   5.1. “Episodes” saraksta sadaļā zem “Characters” tēlu skaita vietā ievietot sarakstu ar tēlu vārdiem.
   Uzklikšķinot uz konkrētā tēla, tiek attēlota informācija par to, vai nu notiekot pāradresācijai uz
   “Characters” saraksta sadaļu (kur redzams tikai šis konkrētais tēls), vai arī atveras modālais dialogs
   (modals);
   5.2. Papildināt “Characters” saraksta sadaļu - uzklikšķinot uz “Episode count”, tiek attēlots saraksts ar
   epizodēm un informāciju par tām, vai nu notiekot pāradresācijai uz “Episodes” saraksta sadaļu (kur
   redzamas tikai konkrētās epizodes), vai arī atveras modālais dialogs (modals).

## Tiks papildus novērtēts, ja būs:

- izveidots mehānisms, kā jau reiz pieprasītus datus saglabāt kešatmiņā (cache), lai lieki nenoslogotu
  API ar atkārtotiem pieprasījumiem;
- izmantots eslint rīks;
- uzrakstīti gan Unit, gan e2e testi.
