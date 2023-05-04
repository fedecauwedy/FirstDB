# FirstDB
Per prima cosa abbiamo creato una cartella con il seguente nome: cognome.nome.4h.firstdb. Successivamente abbiamo aperto la cartella su visual studio code e abbiamo creato il progetto digitando dotnet new console nel terminale.\
Successivamente abbiamo cercato su google il file "chinook.db" e lo abbiamo aggiunto alla cartella creata in precedenza\
successivamente potevamo visualizzare la tabella artists con i seguenti passaggi: installare l'estensione SQlite, poi cliccando con il tasto sinistro del mouse sul file chinook.db e digitare su "apri sul database", in basso a sinistra comparira una finestrella chiamata "SQLITE EXPLORER", dovrai cliccarci e vedere il file chinook.db, poi clicci con il tasto sinitro del mouse e cliccare su "mostra tabella". Infine comparira la tabella a schermo: \
![image](https://user-images.githubusercontent.com/116791048/235087354-100594bf-052a-40da-ae0d-f9d7ec72852f.png)\
Per fare funzionare il programma era necessario inserire la libreria: sqlite-net-pcl\
###
  <ItemGroup>
      <PackageReference Include="sqlite-net-pcl" Version="1.8.116" />
    </ItemGroup>
###
![image](https://user-images.githubusercontent.com/116791048/235083432-ccd72fa0-ad2d-4220-bbf2-88e29f2c94f1.png)\
Il codice era in grado di generare nuovi artisti e lo abbiamo sviluppato nekl seguente modo:\
![image](https://user-images.githubusercontent.com/116791048/235084665-b0a79295-beaa-4c4a-a4e8-d024c3dcd693.png)\

