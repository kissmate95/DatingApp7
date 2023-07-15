
            KOMMUNIKÁCIÓ A WPLRM.EXE ÉS A PLRMAX.EXE KÖZÖTT
            ===============================================

   1. VEVÕKÁRTYA KEZELÉSE
   ======================

   A pénztárgépen a "VÁL.1 + 7" billentyûkombinációval kezdeményezhetjük
   a vevõkártya kódjának a beolvasását (vagy begépelését). A rendszerünkben
   a vevõkártya max. 13 karakterbõl állhat, de jellemzõen 6 karakter.

   A vevõkártya kódját mindig az 1. cikk feldolgozása elõtt kell megadni!
   Ha a nyugtán már szerepelnek tételek, akkor a "késõn" (tehát két tétel
   között) megadott vevõkártyakódokat a rendszer el fogja utasítani.

   A vevõkártya kódjának a megadása után a PLRMAX.EXE program letárolja
   a MAXVVK.TXT file-ba a kártya kódját és a MAXEAN.TXT file-ba a "NO EAN"
   szöveget tárolja le. A PLRMAX.EXE program ezután a PLRVVK.TXT file-ra
   vár, melyet a WPLRM.EXE program állít elõ (tehát vagy elutasítja a kódot,
   vagy pedig elfogadja az 1.2. bekezdés szerint.


   1.1. A MAXVVK.TXT file leírása / elõállítja a PLRMAX.EXE
   ------------------------------------------------------------------------
    1.- 13. / 13 karakter / vevõkártya kódja

   1.2. A PLRVVK.TXT file leírása / elõállítja a WPLRM.EXE
   ------------------------------------------------------------------------
    1.- 1. /  1 karakter / státusz         / 0,1
                                           / 0 - kód elutasítva
                                           / 1 - kód elfogadva
    2.-25. / 24 karakter / megnevezés
   26.-26. /  1 karakter / sorvégjel       / x

   Összesen: 26 karakter

   Példa vevõkártya elfogadására:
   ------------------------------
   1POLAR COMPUTER          x

   Megjegyzés:
   -----------

   A PLRM.EXE elõállítja a PLRVVK.TXT és a PLRVVK.OLD azonos tartalmú
   file-okat. A PLRMAX.EXE feldolgozza a PLRVVK.TXT file-t, majd 1/100
   másodperc eltelte után törli.
   Az utolsóként feldolgozott vevõ másolata tehát a PLRVVK.OLD-ban lesz.

   2. CIKKSZÁMOK KEZELÉSE
   ======================

   A termék kódjának a megadása után a PLRMAX.EXE program letárolja a
   MAXEAN.TXT file-ba a termék kódját és a mennyiségét. A MAXVVK.TXT
   file-ban a "NO CARD" szöveg fog megjelenni. A PLRMAX.EXE program
   ezután a PLREAN.TXT file-ra vár, melyet a WPLRM.EXE program állít elõ
   (tehát vagy elutasítja a kódot, vagy pedig elfogadja) a 2.2. bekezdés
   szerint.
   A termék mennyiségét "elõszorzási technikával" adhatjuk meg, tehát adjuk
   meg elõször a termék mennyiségét, majd nyomjuk meg az "X" (szorzás)
   gombot, s ezek után adjuk meg a termék kódját.

   2.1. A MAXEAN.TXT file leírása / elõállítja a PLRMAX.EXE
   ------------------------------------------------------------------------
    1.- 13. / 13 karakter / cikkszám
   14.-     /  x karakter / mennyiség

   2.2. A PLREAN.TXT file leírása / elõállítja a WPLRM.EXE
   ------------------------------------------------------------------------
    1.- 1. /  1 karakter / státusz         / 0,1,2
                                           / 0 - kód elutasítva
                                           / 1 - normál termék
                                           / 2 - betéti díjas termék
    2.-14. / 13 karakter / cikkszám
   15.-32. / 18 karakter / megnevezés
   33.-33. /  1 karakter / AFA-kód         / 1,2,3,4,5
   34.-34. /  1 karakter / nem használt    / 1
   35.-35. /  1 karakter / tizedesek száma / 0,1,2,3
   36.-36. /  1 karakter / nem használt    / 0
   37.-51. / 15 karakter / egységár (Ft)
   52.-52. /  1 karakter / sorvégjel       / x

   Összesen: 52 karakter


   Példa:
   ------
   25998817520093BORSODI SÖR 0.5 L 3110179            x
   2901          SÖRÖSÜVEG 0.5 L   311025             x

   Megjegyzés:
   -----------
   A PLREAN.TXT file-nak mindig 2 rekordja lesz. A 2. rekordnak csak
   betéti díjas terméknél van szerepe.
   A PLRM.EXE elõállítja a PLREAN.TXT és a PLREAN.OLD azonos tartalmú
   file-okat. A PLRMAX.EXE feldolgozza a PLREAN.TXT file-t, majd 1/100
   másodperc eltelte után törli.
   Az utolsóként feldolgozott tétel másolata tehát a PLREAN.OLD-ban lesz.


   Tiszalök, 2008.11.20.
