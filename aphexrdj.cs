using System;
using System.Threading;

namespace aphexrdj
{
    class Program
    {
        static string aphex =
@"                                                  :y/  -:-                 ``.     .`                 `            ``              `    .--`               ./:--oy-    `` `./.-oddNhs+----`                ``...-+s++yddNddd
                                                 /s/    .:.                `-`      ````                           ` ``  `              `---               :/`  .oo`       ```-ohhdoo:.///..`    ```  ` ``` ::/:sydsssmmdydd
                                                -s/      .::               `         ````-`    ``  `--`    `:/:-.--..-.` `      .`       `.-.             -/:   .:so`         ``-::`````                 `` .:+/+oysyhdhdddd
                                     `         .oo`      .-/-             `          ``-:------::+//:-/. .:---//:`..   :/+//////+ossoooosooo/:``          :/.     os:`                                        . `.-`.``-//-/
                                    ``         /s:        `..`            `          `  .-::-`.---.`.`` ... .-.         `.` .///ososo/-...-:::-.         `--      +yy/`                                       . `.````` ..`.
       `   ` ```                   ``.         oy-   `    `.--`    `..-:++o++:`.... ````.-.``          ```            `       `      `.--.`..--``       `---      /sso.                                                 ````
    ``      ` `                     ``        .hh:        -..-:/++yhhhhhhhhyssoooooo/`  `..                                                 ..-.`..     .--.      /hhy+                                                     
 ` ``...`.-`.``` `` ```. `````       ``` `   `+dhy.``..`:/yssyddhyyysshso+-`            `.-.````                      `   ````  `           .::..-/+/``/::--`     .yhho`                                                    
   /:-  ````````  `  ` `    `       `-.-..   `odhy`.`.-.+yhhddhs++oo+o:---`              `--.....`...```..-//:.          ``````       `---:-:/+/-```/o+++/..       sddh+                                                    
   .``   ...                                  +mh+`  /sosdddh++sss:` `...`               ````     :hs-:ssshhddh:          `       `-::-+++/+ososs+:- `.-oy:`       -hds+                                                    
     `   ..   ``                     .`.`     +h+   `-sshddh/`/+:`  ``-//--//:.           ``````` -syhhhhhhhhhdy:                    `/sssoyy+.---`` ``...``        ydy+                                                    
         .`                          `  `     sh:    `ohhhy- ```   ./:oo++/```.-...               :dmmmmdoooohmmy.                 `:++..-..hmh+..`    ...          oddo                                                   `
                                              sy      /yyo-   ..   .--sssso+/-` `.``          ````ydmdhhy `/::ohmy:            :osys`  ``-:oyy:`      ...           :dh+                                                    
         `                                    ys      :hd:     `      y+```````   :-.`           .mNNh-/h. ..``+shh+`          +ooso/oydhhso+/-`--.`  ```           .ys/                                                    
         ``                                   so      `yy.     .    ``/s`        -ds:o/:   ``  `-soss/` -. :     `-yyo/`   `       `----``      `...:oso-`           oy:`                          `                        
                                              oh       sd`            :ohddyssho++/--:`      `/hmo` ` `    ``      `+yNNs-``````````    ````::/ohNNdo/+shhs/         +N/                                                    
         `                                    -m/      -h-      ` ..  ````````````      ``.-ohh/.          .:         .:shhhhdddddhhhhhydmmmmmdyso/:.`..`--:`        `s:                     ...` `    `                    
                                              .Nm.      +s.    `` `              ``:/osdmmmmh/`      `      -            ``..++++sso++++++:--``      ```              s:           `` ``` .`````    `                       
   ` `  `.`  .                                 mMo      `-:.--   .--/+++++++++sshmddhys+:...`                                                     ..  ``             `o-           ` `    `  .`  `  ```      `     `        
                                               hMm          ``   :+oooshddysssso+-.``                        `                                       ``               :`          `  ` ` ```...     ``   `.` .    ``        
                                               sMM+                    ```                                `  `             `                      `` ``              ./`      -`  .        `--:---/-.-.: ``. `-````.        
                                               :MMm`                                        .`               .           .-/+.                    .`                 +/     `     ``  ` -`   .```` `..  ````   ` `          
                                               `dMMo           ``                       `-:shsyo:..-:/osooyhsdy/:::/:...`.ohms+/..`                  ..             -y:   :-::/::-`- .  .. .`-.--`::+--:--/:--.    `-       
             `                                  :NMm.                              `-/:+syysmNshmdddddmNNNNNNNNNmmddmmmmds/oNNhooso::`                             -yh-   . ` ` ````  -:``-..- `` ``-``   `           `-`   
   ` `   `. `. `-. -`.`  ```      .  `           yNMs                              ..-:/+-yNMNNNmy-.```.--::::--.`..+syyhhhdNm+`--//++://-`       .-              -yh:       ` `.` -.:+oosooh+hyy/+:///`::--.` -/-:-------- 
   ` `   `` :`.`.- -`-`` ``- `       `           .yNd:                          `  ``-:.  +hss::-` `..          `..`       `..       .::://:--.     `:.          -hh+`      `-----`-//:/ooh/smdhdhy-/++/++/:-/oyyhhyhy+h+/+:
`  ``.`     `       `         `                   :hNh:                     `    ..-..`  `-.`                                ` ``         ````.`-`              :sds`        . .`..../.:--:.:///:o+/s+++/oo:/o+//+/oo-``/so:
    ```   `   ``-.`                                :dmd/                       .        /yo/-                                                                 ./ohs.         `-/:.-:`-`.- :-  `.``:/:++-.+yso+o-:::+/+- ``  
                                                    /dNd+`        `-           `      `+y-:+`                                                      --        `+ydh-       ` .:/-+s.:``. .. .....` `  -.-.:so+/+.--:: .`...--
                                                     -sdmo.                          `oh-`+-                                 `-.:///-.              `.       :odds`     `.+` /so`:`+:..--:./:::-`          `   `  ``   ` .-.
`  ` `                                                ./yds/.                       `smo`--                                  -o/-://+o.             `.      `ohdh:      `--`  ..`  ```     ``:``-   `             `      ``.
...::///://.:::-:----:--..`                             .hdmy.                      +hs` .                                   --`    `-.                    `-oyyo-             .``: .:``---..+/+y+.--`.--...:-.````.`  .. -`
         `.......-------.:-`.                            `/dmh:```                  -:--..`````                         `.-:/osysso+++-                    :+ss+/               `  `..- .oho+::-s-:omh-/hdymhhd+s+hh.:sy- :`
                                                           -yhhs/-`                 ``-oso+//.`                             `:-:---.`.                   `./ohy+`  ``    `/++- -.:+sssysyo+//-yoo-+dh:-os::::++:++/+-//so:::
                                                     `      -sdNh++.                   ````   :...``-``:/:++:-.--o+/:.`-/---./o+`     . `                ./ohms.    `    ..:.o+myyhyoNmmmhdmhdhms/sy.`./-/ -  `...  ``:/.::`
                                                             -ydmdss-                ``  ` `  y.-++oy/ohs+s+yhshhsohso/soy+/-`o`    .``            ``   --+ddyo    ``   .shddNs:soh:/dy/h+//hdy/--:.-` -o` .`  `so:   ---`  
                                                              :oymhss..               ` `.``  -:`ssy:+yoo.-/+yssdo/syy+dshmo`-.`                   ``   //mddy`   ``  `-.d:NhhmysdsNdso.`. :+oyyo:s`/      .-         `..-`.
                                                               -ymmdho/              .   ```` :-.:o/+o:s:s/o////hohoy:++ydsyy/-                     .` `/ydmm+     `  ` ..`d ///y:-Nos-.  `              `s.s`+ys/    +`.:.-
ysssos+//--.........`.```                                      ..h+dos/-.                      :`+`.`` ````   :--`-`/.syhydos++                     -` `ydNNm:     `       - /./o+dy+h+h/`y+`/``.`:.    `so.o``.-o.         
:+++oohyhddddddddddmdddddyy+/-`                             `  ` +oyh+y.+                        . : :`./`o-o/+/+/+o/soshhss+.                         .hNNNd                     .  -/:y..dhNmmNdo `-  `s+-.````-          
           `.``..---:---:++o+yys+.-..` `                         .mdmmdd/:                         ` .``/`/-/-.- - :`--`-                              :dmNmd                         ```` ://+++/o:.``  `y`-o.::           
                               --/ss+/`-`   `  `                 `oommmNoo-                                                                           /.ymsN+             `  `                            -/yhyy. `         
-+                                             .                  ..dddNhyo`                                                                          //mNmm-             s:ohhhhhys::+o//-----``                           
d:        :                                                         /:ymmhm.`                                                   .                    `hhNMd+:             +MNNNNNNNMMNNNNNNmNmm/o                    `  `  `
          .                 `                                         symdNss`-                /                             `/`                     -+NNdy`              /N:/----://-----.`.``       `          `   .` .`.`
                                                                      .-m/mMN+y`               `--: .                `   .+:::/   .   `               hdNy:.              +/ /`   .   `                       `    ` -:.````
      .                                                                 +-mmMdN/`          `    `.:`m- `:`           m.  dy-. `   :   :               sNN- +              `  /o  `N-                       ` ``  `.:` `.`-`:
                                                                         .dsMmNh/-        -/:       y. y+s       `//`h/  s-``   ` `   `               `dN+                    /` .d/                       `````   .  `.--`-
                                                                          `:hydNom-       -//o:` .  - `/`s`      .-+``+ `/`o+.:`+.                    .-Ny                     + /` -                     `  ``     ` ````-.
        `                                                                   :omNNN::        .-+: h.`s`-o./. ::` `:-// s+odho/-+:-.                    :.Nd.                   `s +  o                        ``    .`. `.`/.
        .                                                              `  ``/dMNMy`:          `` yo /:.d: :.:s/ ://+s /o/oo`  `                       `sMMh                    + +  o/o                      .   ` ` /. `.`-
   :`+`++ `                    `.`   -                               ``hyysNmMMNN:               +` `` d.    +/  . /s  .  .                            +NMN-.                  `::   /h.                             /:   `/
   hyh`/y -                ..-. +:   y                          ``./hhhMMMMMNMMNh-    -       .  -     -     ``     -                              `:  `yNNNNy-..``             o/    `:                        ` `  -` ` `.
  `hmN-:o`: ``             /o:`:/s`:.y` ``   ` `      `      .-oyyMdmmNMNNMMMMNhss    `   .-  `  +-       `        `      `.   `   .               -s``-/MMMMMmmNsd/.- .        /:     s                   `         -`   .`
  -yhm/:o/y.-y``          /os:o+mNs+/N+ yo . + o    ..o+.-/ +NhMMNMNNMMNNmoMNMMyhs        -/     ++  `   -.`       :  s   `` . y.  +               -+:+h+NMNMMMMMNMMmNo+ .`: :  +.+- /`d                             `-`  ``
 :+hdo/hhhh.oM`.       -` yso/moMhNoydo my.:`h.o  `-dsNMNhN+NMMMMMMMMMMhMh hMMMyoo        `:     .s`:..  :--       + .d`-    - ho  :               :-soh+MMMMMMMMMMMMNM/ hoy`m+.y-hs.s/d..`    /    -`               `    ``
 oddmy/MMMd+hN/ `   -  /. y/s+mdMyNymmh`os+:-y++/yhNMMMMMMMmMMMMMMMMMMhhh+:hMMM+/:-.`             h`/.:  +:: ` `` :+ `+./`   : oy-  `     `     -  .-yhyoNNMMMMMMMMMMhMy+mmdhNy-MoMh+mdhds.    h  ` s.                      
.NNhyh/hMMhhhhm.-   :` o-:s:doNmmdhNmdm.:-o`++NhMMmMMmMMMMMmMMMMMMmdmo:sNsyMMMM`/+:::`   -`       s:/`+` hs. + /- +.  /./.-- : +s-  -`.  .y     y  .-+mysmMMMMMmhMMMNhMNMMMNMdyoMsMhhMmsdy. `/ s  ``o`               `      
`MMdyN/oNNhMmsM-:  .-. o.:o/mmmhoNhNM/m-:`s y:MNMMNMMNmMMMMmMMMMmds-d`:yMhhMMMm.-s:-+s   -.       so/`+- hy -y`+s /   :..`:+`y.-+-  -`:  .N     y  ::+MmsNdNmMMddmNMmMMMMMMdMmhsMsMyyNN/hy` :+ --   -        `              
 MhNsM:smhhmmsM:+  . ` :/s:/mhyssMhhM`d-: s +/MMMMMMMMMMMNmMdMMNNy: o /MMhmMMMm.-s..:o   --     ` +-:.-- +s.:h /h -   -/.`.:-N.     -`-  .N     + ./osmN.NoMMMm+h-ymNMMMMMNsMNosMsdssyd`yh .:+  .                           
 N:soM:oN/hsmsM-:  `    +y--Myo+oN:sy s`  s //MMMMMMMMMNMd:Nshssyyh:/ /Mh/MMMN-  + . /   ``     . -    : :+-+y :s     -+.  :`s            h       /hMmyd m.MMMm/s hyddMMMMN:my:oM:/+sNy +o -`-                `         `   
 y:.od-od //s/M`.       +s..d+-.-y :` `   y //MmNMMMMMMymhsho` .:hMy- `h:.MMN:   .   .                 . .//o+ `:      .     .            .       +hMMhd s yNMM:- .`yhMMyMN :-.+m:./sMd `/   :      `                      `
 `: .o`o+  -/-s         -:  -- ` .        h /+MNdMMMM+Noosh+-   .dMd   `` mNN`                           .:os-                                    +mMMho   .hdM`    ::dM/hs  .:+s-.:-MN  .   .                    `         
  /  -`+   ``./         ..   .            h /+MMmMMMM`/+/.m.    .NMd      +`/`                            `-+                                     +MMMh+    `sd       .h`+-  -/+:  :-MM`     /        `                     
  .    +      `         .`   `            h /sMMNdymM :+/`M`    `yM+                                       .-                           `         .MMMs`     +.        / `   :/h.  :-NM` `  .s                              ";
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Title = "J'aime faire des croquettes au chien";
            //WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayerClass();
            //wmp.URL = "E:\\equationvideo\\scenes\\scene23.wav";
            //wmp.controls.play();
            Thread.Sleep(10191-1250);
            Console.WindowHeight = 1;
            Console.WindowWidth = 1;
            Console.BufferHeight = 19;
            Console.BufferWidth = 19;
            Thread.Sleep(1250);
            for (int i = 0; i < 62; i++)
            {
                Console.SetCursorPosition(rnd.Next(0,Console.WindowWidth), rnd.Next(0,Console.WindowHeight));
                Console.BufferHeight += 1;
                Console.WindowHeight += 1;
                Console.BufferWidth += 2;
                Console.WindowWidth += 2;
                Console.WindowLeft = 0;
                Console.WindowTop = 0;
                Thread.Sleep(36);
            }
            for (int i = 0; i < 49; i++)
            {
                Console.SetCursorPosition(rnd.Next(0, Console.WindowWidth), rnd.Next(0, Console.WindowHeight));
                Console.BufferWidth += 2;
                Console.WindowWidth += 2;
                Thread.Sleep(55);
            }
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.BufferHeight;
            int k = 0;
            for (int i = 0; i < 223; i++)
            {
                for (int j = 0; j < 63; j++)
                {
                    Console.Write(aphex[((j*(222)))+(k)]);
                    Console.SetCursorPosition(i, j);
                    for (int l = 0; l < 13400000; l++) { }
                }
                k += 1;
            }
        }
    }
}
