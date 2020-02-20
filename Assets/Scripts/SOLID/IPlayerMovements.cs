using System;

 interface IPlayerMovements
{
     float Horizontal { get; set; }

     float Vertical { get; set; }

     bool Fire { get; set; }

    event Action FireBullet;
}
