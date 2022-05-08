# Izrada e-dnevnika o specijalističkom usavršavanju doktora medicine
Tim 4 - Tema 1B (izrada e-dnevnika + mentorski pogled (upravljanje specijalizantima od strane mentora))

## Projektni tim
Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Petar Matišić | pmatisic@foi.hr | 0016145882 | pmatisic
Dorian Badel | dbadel@foi.hr | 0016145520 | DorianBadel
Mihael Kožul | mkozul@foi.hr | 0016141878 | mihakozul
Tomislava Cafuk | tcafuk@foi.hr | 0016142716 | tcafuk

## Opis domene
U ovom projektu izrađujemo softversko rješenje za olakšavanje dokumentiranja specijalističkog usavršavanja doktora medicine. Doktori na specijalističkom usavršavanju (dalje specijalizanti) trenutno moraju svakodnevno ispunjavati dva dokumenta: Dnevnik rada doktora medicine na specijalističkom usavršavanju i Knjižica o specijalističkom usavršavanju doktora medicine. Naše softversko rješenje fokusira se na dnevnik rada doktora medicine na specijalističkom usavršavanju, softversko rješenje dalje zovemo e-Dnevnik. Osim ispunjavanja dnevnika specijalist mora i dobivati potvrde od mentora i glavnog mentora kroz cijeli tok specijalizacije koja traje do **5** godina. To sakupljanje potvrda koje dolaze u obliku potpisa i pečata odvlači specijalizante od stjecanja novih vještina i tjera ih da traže mentore i gube vrijeme umjesto da se fokusiraju na stjecanje novih vještina. Naša softverska solucija će riješiti taj problem tako da omogući popunjavanje dnevnika preko računala kao i potvrđivanje radnji sa strane mentora i glavnih mentora. Pretvaranje dnevnika u digitalni oblik će kroz intuitivno sučelje pojednostaviti sve dokumentiranje specijalističkog usavršavanja doktora.

## Specifikacija projekta
 
FZ-1 - Sustav će omogućiti pristup samo autentificiranim korisnicima.  
FZ-2 - Sustav će omogućiti uvoz podataka o odobrenim specijalizantima iz datoteke izvezene iz sustava Ministarstva zdravstva Republike Hrvatske.  
FZ-3 - Sustav će omogućiti ručni unos podataka o Programu specijalizacije iz datoteke Pravilnika o specijalističkom usavršavanju doktora medicine.  
FZ-4 - Sustav će omogućiti ispunjavanje evidencije dnevnika aktivnosti specijalizantima.  
FZ-5 - Sustav će mentorima i glavnim mentorima omogućiti odobravanje unosa u dnevnik aktivnosti i prikaza sluˇcaja bolesnika specijalizanata (ako specijalizacija
to zahtjeva).  
FZ-6 - Sustav će omogućiti ispunjavanje evidencije prikaza slučaja bolesnika specijalizantima (ako specijalizacija to zahtjeva).  
FZ-7 - Sustav će omogućiti ispunjavanje evidencije stručnih radova specijalizantima.  
FZ-8 - Sustav će omogućiti evidentiranje i ocjenjivanje provjera znanja glavnim mentorima.  
FZ-9 - Sustav će za svakog specijalizanta moći prikazati profil s osnovnim informacijama o samom specijalizantu i programu koji pohađa.  
FZ-10 - Sustav mora omogućiti specijalistu da preda zahtjev za polaganje ispita.  
FZ-11 - Sustav omogućava pregled svih mentora za koje je zadužen glavni mentor.  
FZ-12 - Sustav omogućava postavljanje i ažuriranje ishoda učenja i određivanje koje kompetencije su vezane uz koju specijalizaciju.  

**Arhitektura softverskog rješenja**

![Arhitektura softverskog rješenja](https://user-images.githubusercontent.com/101052235/167015149-c0dd2f4e-f658-488c-a28e-82893dd77465.png)

Slika opisuje buduću arhitekturu programskog proizvoda. Buduća arhitektura programskog proizvoda bit će sastavljena na najapstraktnijoj razini od 3 dijela. Mi realiziramo komponentu 2 - sučelje za rad s bazom i 3 - baza podataka. Prva komponenta je sam korisnik koji će imati interakciju sa softverskim rješenjem.

**Podjela odgovornosti** 

Odgovornosti smo podijelili po dogovoru. 

Član tima | Broj funkcionalnosti za koje je odgovoran
--------- | -----------------------------------------
Petar Matišić | 3
Dorian Badel | 3
Mihael Kožul | 4
Tomislava Cafuk | 3

Graf ispod uzima u obzir koliko koji član tima mora napraviti funkcionalnosti, ali uzima i u obzir težinu izrade pojedine funkcionalnosti kao i odgovornosti izvan poput dokumentiranje, izrada baze podataka i sl.

![Podjela odgovornosti](https://user-images.githubusercontent.com/101052235/167015682-cc48c130-504d-4501-8ec0-74034c52150f.png)

Tablica ispod detaljno opisuje o kojim se funkcionalnostima radi.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | **Prijava** | Za pristupiti aplikaciji potrebno je imati autorizirane korisničke podatke koji su dani od ministarstva zdravsta | Petar Matišić
F02 | **Prikaz početnog zaslona** | Forma koja služi za pregled svih mogućnosti koje korisnici mogu odabrati | Dorian Badel
F03 | **Mogućnost ispisa dnevnika** | Omogućava ispis cijelog dnevnika u formatu kako bi izgledao inače u papirnatom obliku | Mihael Kožul
F04 | **Prikaz evidencije stručnih radova iz područja specijalizacije** | Prikazuje i omogućava dodavanje novih stručnih radova | Tomislava Cafuk
F05 | **Prikaz evidencije prikaza slučaja bolesnika** | Prikazuje i omogućava dodavanje novih slučaja bolesnika. Mentor i glavni mentor također mogu odobriti slučajeve | Tomislava Cafuk
F06 | **Prikaz evidencije dnevnih aktivnosti** | Prikazuje i omogućava dodavanje novih aktivnosti. Mentor i glavni mentor također mogu odobriti aktivnosti  | Tomislava Cafuk
F07 | **Pregled profila** | Pristupanje i pregled osobnih i tuđih javnih informacija | Petar Matišić
F08 | **Pregled mentora i specijalizanata** | Glavni mentor može vidjeti sve mentore za koje je odgovoran | Dorian Badel
F09 | **Pregled događaja** | Mentori i glavni mentori mogu vidjeti i potvrditi sve aktivnosti, slučajeve bolesnika, provjera usvojenih znanja koje trebaju provjeriti ili ocijeniti za sve specijalizante | Dorian Badel
F10 | **Prikaz evidencije provjera znanja** | Glavni mentori mogu postaviti provjere znanja kao i pregledati sve obavljene provjere i ocijeniti ih | Mihael Kožul
F11 | **Podatci programa specijalizacije** | Služi za postavljanje minimalnih uvjeta i ishoda učenja za polaganje specijalizacije pojedinog programa | Petar Matišić
F12 | **Mogućnost predaje zahtjeva polaganja ispita** | Pristupnici sa ostvarenim uvjetima mogu zatražiti polaganje ispita | Mihael Kožul
F13 | **Prikaz evidencije bilješki** | Prikazuje i omogućava pregled i unos bilješki | Mihael Kožul

## Tehnologije i oprema
1. Programski jezici: C#, SQL
2. Baza podataka: MySQL, Microsoft SQL Server
3. IDE: Microsoft Visual Studio 2019/2022, MySQL Workbench 8.0 CE, SQL Server Management Studio (SSMS) 18.11
4. Verzioniranje: git (shell), Sourcetree
5. Uredski alati: Visual Paradigm Community, LaTeX, Microsoft Project
6. Prototip: Figma

## Status projekta
- Prva faza projekta u potpunosti gotova
