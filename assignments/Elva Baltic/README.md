## Uzdevums: darbu pārvaldības modulis

### Nosacījumi:
* Drīkst izmantot jebkādus gatavus pieejamus resursus un bibliotēkas
* Risinājumam jābūt balstītam uz Yii framework un kā datubāze jāizmanto MS SQL.
* Jāiesniedz pieeja risinājuma repozitorijam, kur papildus kodam mapē ‘SQL” jābūt
izveidotiem nepieciešamajiem SQL skriptiem.
* Papildus uzdevuma prasībām drīkst veidot datu modeļus un struktūras
funkcionalitātes nodrošināšanai
* Prasības, kas nav definētas, realizēt atbilstoši biznesa procesa izpratnei
Tiks vērtēts:
* Koda kvalitāte un atkārtotas izmantošanas iespējas.
* Funkcionālo prasību nodrošināšana.
* Uzdevuma izpildes ātrums
* 
### Uzdevums
* Izveidot SQL tabulu EMPLOYEE, kurā glabāt darbinieku, tā vārdu uzvārdu, dzimšanas
   dienu, pieejas līmeni, lomu, aizpildīt ar vismaz trīs ierakstiem.
* Izveidot Tabulu CONSTRUCTION_SITE kurā glabāt Būvobjektus, to atrašanās vietu,
   kvadratūru, nepieciešamo pieejas līmeni, aizpildīt ar vismaz trīs būvobjektiem.
* Izveidot tabulu WORK_ITEM kurā glabāt iespējamo darbu sarakstu. Aizpildīt ar vismaz
   trīs iespējamiem darbiem.
* Izveidot 3 līmeņu lomas: admin, manager, employee
* Izveidot funkcionalitāti:
   a. admin ir tiesīgs redzēt, pievienot, rediģēt, dzēst darbiniekus, būvobjektus un
   darbus.
   b. manager ir tiesīgs izveidot darbu sarakstu pakļautajiem darbiniekiem, norādot
   darbu un būvobjektu noteiktam darbiniekam, atbilstoši piekļuves līmenim.
   c. employee ir tiesīgs redzēt sev piešķirto darbu sarakstu un kurā būvobjekta,
   kādi darbi ir jāveic.

* Izveidot API, kur ārēja caurlaižu sistēma var pieprasīt informāciju par Būvobjektu, lai
   uzzinātu kuriem darbiniekiem ir nepieciešama pieeja noteiktam būvobjektam, darbu
   izpildei.