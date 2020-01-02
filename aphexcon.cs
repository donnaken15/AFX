using System;
using System.Threading;

namespace aphexcon
{
    class Program
    {
        static int e;
        static Random d = new Random();
        static string f = "\n                                                                                         ", c, b =
@"
                                                   `-:/+ossyyyhhhhyyysoo+/:-`                                                   
                                           `-/oyhmMMMMMMMMMMMMMMMMMMMMMMMMMMMMmhso:.                                            
                                      `:+ymNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdy+-`                                      
                                  `/sdNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNdo:`                                  
                               -odNMMMMMMMMMMMMMMMmdhyo+/:--...``...-::/+oyhdNMMMMMMMMMMMMMMMNh+-                               
                            :smMMMMMMMMMMMMMmho/-```                        ```-/shmMMMMMMMMMMMMNmo-                            
                         -omMMMMMMMMMMMmho:``                                      `.:ohNMMMMMMMMMMNmo.                         
                      `/hNMMMMMMMMMNho-`                                                `:ohNMMMMMMMMMNh:                       
                    .+mMMMMMMMMMNy/.                                                       `.+hNMMMMMMMMMm+`                    
                  `omMMMMMMMMNh/.                                                              .+hMMMMMMMMMm+`                  
                `omMMMMMMMMmo.                                                                   `-smMMMMMMMMm+`                
               /mMMMMMMMMd/`                                                                        .+mMMMMMMMMd:               
             -hMMMMMMMMd/`                                                                            `+mMMMMMMMNy.             
            +NMMMMMMMm+`                                                                                `oNMMMMMMMm/            
          .yMMMMMMMNs.                                                                                    .yMMMMMMMMs`          
         -mMMMMMMMd:     ``................................................```                              /mMMMMMMMd.         
        /NMMMMMMMs`   .+ydmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmdhs/`                           .yMMMMMMMm:        
       +NMMMMMMN/   `sNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm/                           `oNMMMMMMN:       
      +MMMMMMMm:   `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMs                            /NMMMMMMN:      
     /MMMMMMMm-    /MMMMMMMMMMMAPHEXMMMMMMMMMMMMMMMMMNNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMo                            :NMMMMMMN-     
    -NMMMMMMN-     +MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNh/-.:hMMMMMMMMMMMMMMMMMMMMMMMMMMMM:                            :NMMMMMMm.    
   `mMMMMMMN:      .NMMMMMMMMMMTWINMMMMMMMMMMMMMMh-     `MMMMMMMMMMMMMMMMMMMMMMMMMMMMm.                            /MMMMMMMh    
   sMMMMMMM+        :mMMMMMMMMMMMMMMMMMMMMMMMMMd:       /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMh                             sMMMMMMMo   
  -MMMMMMMh          `+dNNMMMMMMMMMMMMMMMMMNmy/        :NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMo                             dMMMMMMN.  
  dMMMMMMN.             `-:///////////////:-`         /NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:                            -MMMMMMMy  
 :MMMMMMMo                                           +MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN.                            yMMMMMMM. 
 yMMMMMMN`                                          oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh                            .MMMMMMMs 
`NMMMMMMy                                          sMMMMMMMMMMMNyo/+odMMMMMMMMMMMMMMMMMMMMo                            hMMMMMMm 
:MMMMMMM:                                         yMMMMMMMMMMMm.      /NMMMMMMMMMMMMMMMMMMM:                           +MMMMMMM.
sMMMMMMM`                                       `hMMMMMMMMMMMMy        .dMMMMMMMMMMMMMMMMMMN.                          .MMMMMMM+
hMMMMMMm                                       `dMMMMMMMMMMMMMm         `yMMMMMMMMMMMMMMMMMMd                           NMMMMMMs
dMMMMMMd                                      .mMMMMMMMMMMMMMMM`          +MMMMMMMMMMMMMMMMMMs                          NMMMMMMy
mMMMMMMy                                     -NMMMMMMMMMMMMMMMM-           -mMMMMMMMMMMMMMMMMM:                         dMMMMMMh
mMMMMMMh                                    -NMMMMMMMMMMMMMMMMM:            `hMMMMMMMMMMMMMMMMN.                        mMMMMMMh
hMMMMMMd                                   :NMMMMMMMMMMMMMMMMMm`              oMMMMMMMMMMMMMMMMd                        NMMMMMMs
yMMMMMMN                                  /MMMMMMMMMMMMMMMMMms`                /NMMMMMMMMMMMMMMMs                      `MMMMMMMo
+MMMMMMM-                                +MMMMMMMMMMMNy/-.```                   .mMMMMMMMMMMMMMMM/                     /MMMMMMM:
.MMMMMMMo                               sMMMMMMMMMMNs`                           `yMMMMMMMMMMMMMMN.                    yMMMMMMN`
 dMMMMMMm                             `yMMMMMMMMMMd-                               +MMMMMMMMMMMMMMd`                  `NMMMMMMh 
 +MMMMMMM:                           `hMMMMMMMMMN+`                                 :mMMMMMMMMMMMMMs                  +MMMMMMM: 
 `NMMMMMMd                          `hMMMMMMMMMy.                                    .dMMMMMMMMMMMMM/                `NMMMMMMd  
  +MMMMMMM+                        .dMMMMMMMMm:                                       `sMMMMMMMMMMMMN.               sMMMMMMM:  
   dMMMMMMN.                       dMMMMMMMNs`                                          /NMMMMMMMMMMMd`             :MMMMMMMh   
   -NMMMMMMd`                      dMMMMMMd-                                             -mMMMMMMMMMMMs            .mMMMMMMN.   
    +MMMMMMMh`                     .ydmmh/`                                               .hMMMMMMMMMMM/          `dMMMMMMM/    
     yMMMMMMMy`                      `.`                                                   `oMMMMMMMMMMN-        `hMMMMMMMo     
     `hMMMMMMMy`                                                                             /NMMMMMMMMMh       .hMMMMMMMs      
      `hMMMMMMMh.                                                                             -dMMMMMMMMN      -dMMMMMMMs`      
       `yMMMMMMMm:                                                                             `yNMMMMMN+     /NMMMMMMMs        
        `sMMMMMMMNo`                                                                             -ohhho-    `sMMMMMMMN+         
          /NMMMMMMMd-                                                                                      :dMMMMMMMm:          
           -dMMMMMMMNs.                                                                                  .yMMMMMMMMh.           
            `oNMMMMMMMmo.                                                                              .sNMMMMMMMN+             
              -hMMMMMMMMm+.                                                                          .oNMMMMMMMNy.              
                /mMMMMMMMMNs.                                                                     `-sNMMMMMMMMd:                
                 `+mMMMMMMMMNh/`                                                                .+hMMMMMMMMMd/`                 
                   `+dMMMMMMMMMmy:`                                                          `/yNMMMMMMMMMd/`                   
                     `/hNMMMMMMMMMmy/.`                                                  `.+yNMMMMMMMMMNy:                      
                        -omMMMMMMMMMMNds/.`                                          `./sdMMMMMMMMMMMmo.                        
                           :yNMMMMMMMMMMMMmyo:.``                              ``./ohmMMMMMMMMMMMMms:                           
                             `:smMMMMMMMMMMMMMMNdys+/-.````          ````.-/+shdNMMMMMMMMMMMMMNms:                              
                                 -+hNMMMMMMMMMMMMMMMMMMMNmmddhhhhhhddmmNMMMMMMMMMMMMMMMMMMMNy+.                                 
                                     -+ymMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMds/-                                     
                                         `-+shmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmhs/-`                                         
                                                .:/osydmmNMMMMMMMMMMMMNmdhyso/:.                                                
", a =
@"
                                                 `-:+osyhddmmNNNNNNmmddhyso+:-`
                                          `-/shmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNmhs/-`                                          
                                     `:+ymMMMMMMMMMNdhyso++//:::::://++osyhdNMMMMMMMMMmy+:`                                     
                                 `:odNMMMMMMmhs+:.``                         `.:+shmMMMMMMNdo:`                                 
                              .+hNMMMMMmho:.`                                      `.:ohmMMMMMNh+.                              
                           .+dNMMMMmy+-`                                                `-+ymMMMMNd+.                           
                        `/hNMMMMds-`                                                        `-sdMMMMNh/`                        
                      -sNMMMMdo-`                                                              `-odMMMMNs-                      
                    :hNMMMNy-`                                                                    `-yNMMMNh:                    
                  :hNMMMd+.                                                                          .+dMMMNh:                  
                -hNMMMd/`                                                                              `/dMMMNh-                
              .sNMMMd/`                                                                                  `/dMMMNs.              
             /mMMMm+`                                                                                      `+mMMMm/             
           .yMMMMy.                                                                                          .yMMMMy.           
          :mMMMm:         `-:/+++++++++++++++++++++++++++++++++++++++++++++/:-.`                               :mMMMm:          
         +NMMMy.        -smNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmds:`                             .yMMMN+         
        oMMMMo`       `sNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd:                             `oMMMMo        
       sMMMN/         yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy`                             /NMMMs       
      sMMMN:         .MMMMMMMMMMMMAPHEXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`                             :NMMMs      
     oMMMN:          .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMdo//sNMMMMMMMMMMMMMMMMMMMMMMMMMMMs                              :NMMMo     
    /MMMM/            hMMMMMMMMMMMTWINMMMMMMMMMMMMMd/     -MMMMMMMMMMMMMMMMMMMMMMMMMMMM:                              /MMMM/    
   .NMMMs             `yMMMMMMMMMMMMMMMMMMMMMMMMMmo`      .NMMMMMMMMMMMMMMMMMMMMMMMMMMMm`                              sMMMN.   
   hMMMd`               :hNNMMMMMMMMMMMMMMMMMMNd+`       .mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy                              `dMMMh   
  /MMMM-                  `:/ooooooooooooooo+/.         -mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+                              -MMMM/  
  mMMMs                                                :NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN.                              sMMMm  
 /MMMM.                                               /NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd                              .MMMM/ 
 hMMMy                                               /MMMMMMMMMMMMNNNNMMMMMMMMMMMMMMMMMMMMMo                              yMMMh 
`MMMM:                                              +MMMMMMMMMMMm/.  `:dMMMMMMMMMMMMMMMMMMMM-                             :MMMM`
/MMMM                                              oMMMMMMMMMMMN.       sMMMMMMMMMMMMMMMMMMMm`                             MMMM/
sMMMd                                             yMMMMMMMMMMMMN`        +MMMMMMMMMMMMMMMMMMMs                             dMMMs
hMMMy                                           `hMMMMMMMMMMMMMMh`        :NMMMMMMMMMMMMMMMMMM:                            yMMMh
dMMMo                                          `dMMMMMMMMMMMMMMMMs         .mMMMMMMMMMMMMMMMMMN`                           oMMMd
mMMMo                                         `mMMMMMMMMMMMMMMMMMd          `hMMMMMMMMMMMMMMMMMh                           oMMMm
dMMMo                                        .mMMMMMMMMMMMMMMMMMM/            sMMMMMMMMMMMMMMMMM+                          oMMMd
hMMMy                                       -NMMMMMMMMMMMMMMMMMN/              +MMMMMMMMMMMMMMMMN.                         yMMMh
sMMMd                                      :NMMMMMMMMMMMMMNNmy+`                :NMMMMMMMMMMMMMMMd                         dMMMs
/MMMM                                     /NMMMMMMMMMMN+.```                     .mMMMMMMMMMMMMMMMo                        MMMM/
`MMMM:                                   +MMMMMMMMMMMy`                           `hMMMMMMMMMMMMMMM-                      :MMMM`
 hMMMy                                  oMMMMMMMMMMd:                              `sMMMMMMMMMMMMMMm`                     yMMMh 
 /MMMM.                                sMMMMMMMMMNo`                                 +MMMMMMMMMMMMMMs                    .MMMM/ 
  mMMMs                              `yMMMMMMMMMh-                                    :NMMMMMMMMMMMMM/                   sMMMm  
  /MMMM-                            `hMMMMMMMMm/`                                      -mMMMMMMMMMMMMN.                 -MMMM/  
   hMMMd`                           sMMMMMMMMy.                                         .hMMMMMMMMMMMMh                `dMMMh   
   .NMMMs                           /MMMMMMd:                                            `sMMMMMMMMMMMM+               sMMMN.   
    /MMMM/                           :shdy+`                                               +NMMMMMMMMMMN.             /MMMM/    
     oMMMN:                             `                                                   /NMMMMMMMMMMd`           :NMMMo     
      sMMMN:                                                                                 -mMMMMMMMMMMo          :NMMMs      
       sMMMN/                                                                                 .hMMMMMMMMMN.        /NMMMs       
        oMMMMo`                                                                                `sMMMMMMMMN`      `oMMMMo        
         +NMMMy.                                                                                 +mMMMMNd:      .yMMMN+         
          :mMMMm:                                                                                 `-/+/-`      :mMMMm:          
           .yMMMMy.                                                                                          .yMMMMy.           
             /mMMMm+`                                                                                      `+mMMMm/             
              .sNMMMd/`                                                                                  `/dMMMNs.              
                -hNMMMd/`                                                                              `/dMMMNh-                
                  :hNMMMd+.                                                                          .+dMMMNh:                  
                    :hNMMMNy-`                                                                    `-yNMMMNh:                    
                      -smMMMMdo-`                                                              `-odMMMMNs-                      
                        `/hNMMMMds-`                                                        `-sdMMMMNh/`                        
                           .+dNMMMMmy+-`                                                `-+ymMMMMNd+.                           
                              .+hNMMMMMmho:.`                                      `.:ohmMMMMMNh+.                              
                                 `:odNMMMMMMmhs+:.``                         `.:+shmMMMMMMNdo:`                                 
                                     `:+ymMMMMMMMMMNdhyso++//:::::://++osyhdNMMMMMMMMMmy+:`                                     
                                          `-/shmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNmhs/-`                                          
                                                 `-:+osyhddmmNNNNNNmmddhyso+:-`                                                 
";
/*@"
                     `-/oyhdmNNNNNNmdhyo/-`                     
                 -ohNMNhso/:-......-:/oshNMNho-                 
             `/yNMho:`                    `:ohMNy/`             
           -yNNy:                             `:yNNy-           
         :dMd/                                    /dMd:         
       -dMh-                                        -hMd-       
     `sMm:                                            :mMs`     
    .mMs    :yddddddddddddddddddddddddhs:               sMm.    
   -NM/    hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm:              /MN-   
  -NM:    `MMMMMMMMMMMMMMMmssNMMMMMMMMMMMMM-              :MN-  
 `NM/      +MMMMMMMMMMMMN+   sMMMMMMMMMMMMMm`              /Mm` 
 yMy        `/ossssssso:    oMMMMMMMMMMMMMMMy               yMy 
.MM`                       sMMMMMMMMMMMMMMMMM/              `MM.
oMy                       yMMMMMy::sMMMMMMMMMN.              yMo
dM/                     `hMMMMMM`   :NMMMMMMMMd              /Md
NM:                    `dMMMMMMMh    .mMMMMMMMMo             :MN
NM:                   .mMMMMMMMMy     `hMMMMMMMM-            :MN
dM/                  -NMMMMMdhy/        sMMMMMMMm`           /Md
oMy                 :NMMMMy.             /MMMMMMMy           yMo
.MM`               /MMMMm:                -NMMMMMM/         `MM.
 yMy              +MMMMo`                  .dMMMMMN.        yMy 
 `NM/             sMMh.                     `yMMMMMd       /Mm` 
  -NM:                                        oMMMMMo     :MN-  
   -NM/                                        /NMMMM`   /MN-   
    .mMs                                        .ydh/   sMm.    
     `sMm:                                            :mMs`     
       -dMh-                                        -hMd-       
         :dMd/                                    /dMd:         
           -yNNy:`                            `:yNNy-           
             `/yNMho:`                    `:ohMNy/`             
                 -ohmMNhso/:-......-:/oshNMNho-                 
                     `-/oyhdmNNNNNNmdhyo/-`                     ";*/

        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                //Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 7);
                //Console.ForegroundColor = (ConsoleColor)new Random().Next(0, 16);
                if (d.Next(0, 4) >= 1)
                {
                    c = a;
                    if (d.Next(0, 3) == 1)
                        c = c.Replace("M", "@");
                    e = d.Next(0, 2048);
                    for (int i = 0; i < e; i++)
                    {
                        if (d.Next(0, 5) >= 2)
                            c = c.Insert(d.Next(0, c.Length), new string((char)d.Next(0x20, 0xFF), d.Next(1, 5)));
                        c = c.Remove(d.Next(0, c.Length - 4), d.Next(0, 4));
                    }
                    Console.Write(c.Replace("\n", "\n                                                                                         "));
                }
                switch (d.Next(0, 4))
                {
                    case 0:
                        Console.Write(a.Replace("\n", f));
                        break;
                    case 1:
                        Console.Write(a.Replace("\n", f).Replace("M", "@"));
                        break;
                    case 2:
                        Console.Write(a.Replace("\n", f).Replace("M", "A"));
                        break;
                    case 3:
                        Console.Write(a.Replace("\n", f).Replace("M", "☺"));
                        break;
                }
                if (d.Next(0, 9) >= 7) Console.Clear();
                if (d.Next(0,5) >= 4) Thread.Sleep(new TimeSpan(d.Next(0,900000)));
            }
        }
    }
}
