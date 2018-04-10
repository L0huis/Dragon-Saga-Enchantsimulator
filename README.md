# Dragon-Saga-Enchantsimulator# Dragon-Saga-Enchantsimulator

It is used to calculate an expected usage of normal/reinforced insurance scrolls (IS/RIS) for enchanting and/or soulcrafting.

## How the success probability is calculated:

First of all probabilities to succeed at enchanting/soulcrafting have been confirmed by the game developers.
Calculating the success probability is pretty simple. There are 3 things that affect the success probability:

1.  Additional equipment.
2.  Enchant events.
3.  Emporia buff.

### Additional equipment:

There are different equipment pieces or achievements that increase the base probability (e.g. Unity Rose, [Event] Pirate Balloon). The probability is added on to the base probability. This has been confirmed by the game developers.

### Enchant event:

When an enchant event occurs the base probability is multiplied by some factor the event adds (usually 1.5 or 2). So for very low success probabilities it is almost negligible.

### Emporia buff:

The emporia buff just adds 20% to the base probability. So the base probability is just multiplied by 1.2 (+20%).

## How a specific value is calculated:

There are two different ways to calculate the expected usage of insurance scrolls.

1.  Calculate the average number of tries until success for each level of enchanting, which in turn will be equal to the average number of IS/RIS used.
2.  Calculate the number of tries for at least one success with a certain probability entered by the user.

### Average number of IS/RIS used:

1.  Each success probability is calculated.

* multiplying the base probability by the event/emporia factor
* adding all additional equipment

2.  Calculating the expected IS/RIS usage for each success probability `p`.

* using the formula: `1/p`

3.  Accumulate all expected IS/RIS used to calculate the total IS/RIS needed.

### IS/RIS needed with a specific certainty `c`:

1.  Each success probability is calculated.

* multiplying the base probability by the event/emporia factor
* adding all additional equipment

2.  Calculating the expected IS/RIS usage for each success probability `p`.

* using the formula: `log(1-c)/log(1-p)`

3.  Accumulate all expected IS/RIS used to calculate the total IS/RIS needed with a certainty `c` that the process will succeed at least once.

## How to use the program:

Inputs:

| Label               | Values             | Description                                                                                                           |
| ------------------- | ------------------ | --------------------------------------------------------------------------------------------------------------------- |
| Chance Increase     | 0 - 100            | Probability added on to the base probability                                                                          |
| Enchant event       | ≥ 0                | Factor the base probability gets multiplied by                                                                        |
| Item to enchant     | Weapon, Armor      | Weapons and armor have different base probabilities                                                                   |
| From                | 0 - 19             | Enchantment level the item has and/or IS/RIS is used from                                                             |
| To                  | 1 - 20             | Enchantment level the item should have                                                                                |
| From Soulcraft      | Normal to Artifact | Soulcraft level the item has and/or IS/RIS is used from                                                               |
| To Soulcraft        | Advanced to Legend | Soulcraft level the item should have                                                                                  |
| Success probability | 0 - 100            | Probability to succeed at least once in a single enchantment. Value of `0` calculates the **average** usage of IS/RIS |

After all the inputs are set click on the `Craft` button to get the expected number of IS/RIS.
