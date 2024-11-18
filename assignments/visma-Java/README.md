Testa uzdevums
### Vispārējais apraksts
“Local” kinoteātrim ir nepieciešams serviss, kas nodrošinātu ārējo saskarni biļešu iegādei.

Kinoteātrī ir pieejama “local” datubāze, kurā tiek glabāta informācija par pieejamiem seansiem kinoteātrī, papildus ir pieejams API, ar kura palīdzību var atgūt datus par visiem kinoteātriem pilsētā.

### Vispārējās prasības
Izveidot “local movie service”, ar kura palīdzību var atgūt datus par pieejamajiem seansiem , to biļešu cenām un iespēju pasūtīt biļeti. Risinājumam jānodrošina iespēja atgūt datus un pasūtīt biļeti gan “Local” kinoteātrī, gan pilsētas mērogā.

### Risinājuma komponentes

Risinājumam jānodrošina sekojoša funkcionalitāte:

- Datu atgūšana par pieejamajiem seansiem konkrētajā dienā;
- Biļetes pasūtīšanu uz konkrēto seansu.

### Seansa datu atgūšana
#### Procesa plūsmas shēma

#### Detalizēts apraksts
Izveidot ārējo saskarni, ar kuras palīdzību var atgūt visu pilsētā esošo kinoteātru seansus pēc norādītā datuma. Saskarnes izveidē jāizmanto REST arhitektūras pamatprincipi. Saskarnei jānodrošina sekojošais “endpoint”.


|GET http://localhost:8081/api/v1/sessions?date=2012-12-12|
| :- |

Pieprasījuma apstrādes laikā jāatgūst visi pieprasījumā norādītā datuma pieejamie seansi gan no “local” datubāzes, gan no Moviet-api. 

Dati ir jāapvieno un jātgriež atbilde. Atbildē jāievēro sekojoša struktūra.


|<p>{</p><p>`    `"sessions": [</p><p>`        `{</p><p>`            `"id": 2,</p><p>`            `"date": "2022-03-31",</p><p>`            `"movie": {</p><p>`                `"price": 14.5,</p><p>`                `"title": "Horrible Bosses 2"</p><p>`            `},</p><p>`            `"cinema": {</p><p>`                `"address": "9102 Leroy St San Gabriel",</p><p>`                `"name": "The Local"</p><p>`            `},</p><p>`            `"auditorium": {</p><p>`                `"auditorium\_nr": 30,</p><p>`                `"seat\_count": 30</p><p>`            `}</p><p>`        `},</p><p>`        `{</p><p>`            `"id": 3,</p><p>`            `"date": "2022-03-31",</p><p>`            `"movie": {</p><p>`                `"price": 13.5,</p><p>`                `"title": "Crash"</p><p>`            `},</p><p>`            `"cinema": {</p><p>`                `"address": "44 Temple Ave. Nottingham",</p><p>`                `"name": "The Monolith"</p><p>`            `},</p><p>`            `"auditorium": {</p><p>`                `"auditorium\_nr": 31,</p><p>`                `"seat\_count": 31</p><p>`            `}</p><p>`        `}</p><p>`    `]</p><p>}</p>|
| :- |

### Biļetes pasūtīšana
#### Procesa plūsmas shēma

#### Detalizēts apraksts
Izveidot ārējo saskarni, ar kuras palīdzību var pasūtīt kinoteātra biļeti. Pieprasījumā tiek padots klienta e-pasts, seansa identifikators un kinoteātra nosaukums. Saskarnes izveidē jāizmanto REST arhitektūras pamatprincipi. Saskarnei jānodrošina sekojošais “endpoint”.


|<p>` `POST http://localhost:8081/api/v1/orders</p><p></p><p>{</p><p>`    `"cinema\_name": "citizenk1234@ichstet.com",</p><p>`    `"email": "citizenk1234@ichstet.com",</p><p>`    `"show\_cast\_id": 2</p><p>}</p>|
| :- |

Procesa izpildes laikā ir jāpārbauda, vai tiek veikts biļetes pasūtījums “Local” kinoteātrim vai pilsētas mērogā, izmantojot pieprasījumā padoto kinoteātra nosaukumu. Ja tiek pieprasīta “Local” kinoteātra biļete, tad tālākā procesa plūsmā tiks izmantoti dati tikai no “Local” datubāzes, pretējā gadījumā procesa plūsmā tiks izmantoti dati no Moviet-api.

**“Local” kinoteātra biļetes pasūtīšanas procesa apraksts**

Process iedalās sekojošos soļos:

- Atgūst seansa datus no datubāzes  ar pieprasījumā norādītā seansa identifikatoru.
- Atgūst klienta datus no datubāzes ar pieprasījumā norādītā klienta e-pastu.
- Izveido jaunu Ordera datubāzes ierakstu, kurš sastāv no atgūtā klienta identifikatora un seansa identifikatora.

**Pilsētas mēroga biļetes pasūtīšanas procesa apraksts**

Process iedalās sekojošos soļos:

- Atgūst seansa datus no Moviet-api ar pieprasījumā norādītā seansa identifikatoru.
- Atgūst klienta datus no Moviet-api ar pieprasījumā norādītā klienta e-pastu.
- Izveido jaunu Ordera POST pieprasījumu uz Moviet-api, kurš sastāv no atgūtā klienta identifikatora un seansa identifikatora.

**Izsaukuma atbilde**

Processa izpildes beigās tiek atgriezts procesa izpildes datums. Atbildei jāievēro sekojoša struktūra:


|<p>{</p><p>`    `"date": "2022-03-31"</p><p>}</p>|
| :- |




### Izmantoto komponenšu informācija
Izstrādes izpildei ir pieejamas sekojošās komponentes:

- LocalMovietDb.mv.db - H2 datubāzes fails, kā lokālā kinoteātra datubāze.
- MovietApiDb.mv.db - H2 datubāzes fails ārējam servisam (moviet-api), nav nepieciešama tieša mijiedarbība ar šo failu.
- Moviet-api.jar – Serviss, ar kuru ir jāveic integrācija.


#### “Local Movie” datubāzes 
Datubāze sastāv no vairākām tabulām, kurās glabājās informācija par vietējā kīnoteatra - auditorijām, filmām, klientiem, klientu pasūtījumiem. 

**Datubāzes shēma**

**Datubāzes pielietojums**

Servisam jāizmanto LocalMovietDb.mv.db fails, kā vietējā kinoteātra datubāze. Datubāzes apskates nolūkam var izmantot H2 konsoli. Konsoli iespējams lejuplādēt izmantojot sekojošo saiti:

|http://www.h2database.com/html/download.html|
| :- |

Pieslēguma izveidei ir piejams sekojošais lietotājs:

|<p>User: admin</p><p>Password: parole123</p>|
| :- |

#### Moviet-api
Api nodrošina saskarni mijiedarbībai ar MovietApiDb.mv.db datubāzes failu.

**Api pielietojums**

Servisu piestartē izmantojot komandu:


|java -jar moviet-api.jar|
| :- |

Api nodrošina Swagger interfeisu, esošo “endpoint” dokumentēšanai, interfeiss ir pieejams sekojošā adresē:

|http://localhost:8080/swagger-ui/index.html|
| :- |

Serviss izmanto “basic” autorizāciju, pieprasījuma izveidei jāizmanto sekojošie autorizācijas dati:

|<p>User: admin</p><p>Password: parole123</p>|
| :- |


#### Projektā obligāti izmantojamās tehnoloģijas
- Spring boot
- Spring Webclient vai Spring RestTemplate
