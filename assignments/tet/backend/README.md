## Uzdevums

Jāuztaisa mikroserviss, kas nolasa valūtu kursus no https://www.bank.lv/vk/ecb_rss.xml, saglabā tos datubāzē, un attēlo šos datus no API.

Mikroserviss sastāv no 2 "endpointiem":
- Datu attēlošana no datubāzes - jaunākās valūtas kursu vērtības.
- Datu attēlošana no datubāzes - vēsturiskās vērtības konkrētam valūtas kursam.

Papildus jāuztaisa 2 konsoles komandas:
- Komanda, kuru izpildot tiek ielādēti dati no RSS un saglabāti DB.
- Komanda, startē mikroservisu, lai "endpointi" ir pieejami lietotājiem.

## Nosacījumi
Vēlams izmantot Java vai Go programmēšanas valodu. Ja lieto Java, tad nedrīkst lietot ietvarus (Spring, Spring Boot, Quarkus, Micronaut, utt.), jāpielieto bibliotēkas (https://javalin.io/, JDBC, datastax-java-driver), un projekts jāstrukturē pašam.

Vēlams izmantot MySQL(MariaDB) vai Cassanadra datubāzes.

Jāpiegādā viss kods, db daļa un readme iekš github (vai citās versiju kontroles sistēmās, kurās izmanto git).

Readme jābūt aprakstītai instrukcijai, kuru izlasot ir skaidrs, kas secīgi jādara, lai lietojumu uzstādītu un palaistu (vēlams uz Docker).