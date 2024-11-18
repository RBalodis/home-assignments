Darba uzdevums:

1. Uz datora izvēlētā katalogā tiek iekopēti `n` audiofaili. Ņemam šim darba uzdevumam dažādu formātu audiofailus - mp3, wav, aac. Respektīvi piemērā ir jābūt vismaz 3 dažādu formātu audiofailiem. Vēlams izveidot lielāku failu skaitu. Audiofailu saturs ir diktēts teksts (Tekstus var iediktēt piemēram šeit un dabūt dažādu formātu failus: https://online-voice-recorder.com/ var izmantot konvertoru: https://www.online-convert.com/ ). Mums nav svarīgi kā tiek veidoti šie audio faili. Vēlams lai teksts ir skaidri iediktēts un audio ir bez liekiem trokšņiem, latviešu valodā.

2. Jāizveido SW modulis, kurš sākotnēji nolasa audiofailu katalogu un ieraksta failu nosaukumus json datu struktūrā. Respektīvi rezultātā ir json formāta audiofailu saraksts. Vēlams sarakstā blakus faila nosaukumam norādīt arī audio ilgumu.

3. Taustiņa (piemēram izveidojam pogu "Atskaņot failus") klikšķis inicializē audio pleijeri (ir jāatrod webisks audiopleijeris, kurš atbilst uzdevuma nosacījumiem).

4. Audiopleijerim ir jāspēj parādit playlisti no izveidotā json. Blakus katram faila nosaukumam ir jāredz audio ilgums.

5. Audiopleijerim jānodrošina sekojoša funkcionalitāte:

- atskaņot/pauze/stop/ nākamais audio/iekpriekšējais audio

- atskaņojot jāredz pilnais audio ilgums/ tekošā atskaņošanas pozīcīja

- jābūt grafiskai vizualizācijai kurā vietā šobrīd skan audio, vālams lai ar peli var pārcelt atskaņošanas pozīciju

- jābūt iespējai regulēt skaļumu (nav obligāta)

- jābūt iespējai mainīt atskaņošanas ātrumu

- jābūt iespējai pārslēgt starp pauzi/atskaņošanu ar taustiņu - piemēram izmantojot "space"

6. Automātiski jāatskaņo visa playliste, visi audiofaili pēc kārtas (jaukta secība nav nepieciešama).

7. Jāvar aizvērt pleijeri un atgriezties sākuma ekrānā.
