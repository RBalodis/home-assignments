Pamatuzdevums:
Izstrādāt lietojumu, kas pēc lietotāja IP adreses atgriež šī brīža laika ziņas (weather forecast).
Prasības:
• Jāizmanto Symfony 5.3 ietvars un PHP 8.0.
• Jāveido projekts pēc iespējas cenšoties izmantot Symfony prakses, MVC un OOP principus (vēlams
arī KISS un SOLID).
• Lietojums ir jādala atsevišķos servisos, kas veic šādas darbības:
o Iegūst lietotāja IP adresi
o Pēc IP adreses iegūst lietotāja atrašanās vietu
o Pēc atrašanās vietas atrod šī brīža laika ziņas
o Publiskajā pusē ir jāatgriež laika ziņas (temperatūra, vēja ātrums, nokrišņi utt.) JSON
formātā.
• Jāizmanto cache principi, lai, piemēram, nemainoties IP adresei vai atrašanās vietai, netiek veikti
atkārtoti pieprasījumi šo datu iegūšanai.
• Jāizmanto Symfony HttpClient.
• Jābūt iespējai iegūt atjaunotus datus pēc pieprasījuma.
• Projektu ir jāpiegādā izmantojot GitHub. Ja nevēlies repozitoriju atstāt publisku, vari izmantot rīku
https://gitfront.io/
Papildus uzdevums (mājas darbu vari droši veikt arī bez šī, bet noteikti novērtēsim, ja izpildīsi):
Izmantojot PostgreSQL, saglabā katras IP adreses atrašanās vietu datubāzē un mainoties IP adresei
pārbaudi vai šāda IP adrese jau nav saglabāta. Ja ir, tad izmanto datubāzes datus. Ja nav, pieprasi jaunus.
Informācija:
• Ievads par Symfony ietvaru: https://symfonycasts.com/screencast/symfony
• Symfony dokumentācija: https://symfony.com/doc/current/index.html
• Atsaucei uz to, kādas ir Symfony prakses, var izmantot šo: https://github.com/symfony/demo
Nav būtiski kādi API tiek izmantoti datu iegūšanai, bet, ja tie nav mūsu piedāvātie, lūdzu pievieno
informāciju, kā šiem API pieslēgties.
Mēs iesakām laika ziņu datiem izmantot https://openweathermap.org, piedāvājam arī testa API atslēgas
uzdevuma veikšanai, vēlams izmantot vienu (limits: 60 izsaukumi/minūtē):
26e29aa16ee3a3a8af761f4dd0410824
75644221927cf43372e9901b8ab3fce1
a9fb4d1106184cab9b8789842aade914
Atrašanās vietas iegūšanai iesakām izmantot https://ipstack.com, piedāvājam arī testa API atslēgas
uzdevuma veikšanai, vēlams izmantot vienu (limits: 1000 izsaukumi/dienā):
4ad0e02fbf2e1a55a886b65c9d4a7644
ff0dc6aefeed23e9ed7517f34831efab
7cdd5c912853213038180e6765e3edc1
Veiksmi mājasdarba izpildē!
