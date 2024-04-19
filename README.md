classDiagram
    Character <|-- Enemy
    Character <|-- Player
    Character o-- Weapon
    Weapon <|-- Gun
    Weapon <|-- Sword

    class Character {
      -Weapon[] weapons
      +string Name
      +void Fight()
    }

    class Enemy {
      +Enemy(string name)
    }

    class Player {+Player(string name)}

    class Weapon {
      -float power
      +Weapon(float power)
    }

    class Gun {
      -int Ammo
      +Gun(float power, int ammo)
      +void FireGun()
    }

    class Sword {
      -float BladeLength
      +Sword(float power, float bladeLength)
      +void AttackWithSword()
    }