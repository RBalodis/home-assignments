## Jāizveido C# console app, kas imitē Modbus TCP/IP klienta pusi, neizmantojot trešo pušu bibliotēkas.

Rezultātā gribētu redzēt kodu, kas ik pēc 5min pieslēdzas trīs dažādiem serveriem (imitēts saraksts) un nolasa kāda reģistra vērtību.

- Nepieciešamās metodes -
- Constructor  ModbusClient(string ipAddress, int port)
- void Connect()
- void Disconnect()
- void WriteRegister(int address, int value)
- int ReadRegister(int address)
- bool ReadCoil(int address)
- void WriteCoil(int address, bool value)

- + unit tests


- Te neliels špikeris un palīgs uzdevuma atrisināšanai, tur ir gan server, gan client simulatori - http://easymodbustcp.net/codesampleseasymodbustcp-net