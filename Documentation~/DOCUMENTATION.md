# Documentation
## API
Note: See [easings](https://easings.net/) for visual example of API effects.

| **Method** | **Parameters** | **Returns** | **Description** |
| - | - | - | - |
| `Ease` | `UEaseType, float` | `float` | *Interpolates t using specified easing function.* |
| `EaseInSine` | `float` | `float` | *Sine entry, linear exit.* |
| `EaseOutSine` | `float` | `float` | *Linear entry, sine exit.*|
| `EaseInOutSine` | `float` | `float` | *Sine entry and exit, linear middle.*|
| `EaseInQuad` | `float` | `float` | *Quadratic entry, linear exit.*|
| `EaseOutQuad` | `float` | `float` | *Linear entry, quadratic exit.*|
| `EaseInOutQuad` | `float` | `float` | *Quadratic entry and exit, linear middle.*|
| `EaseInCubic` | `float` | `float` |  *Cubic entry, linear exit.*|
| `EaseOutCubic` | `float` | `float` | *Linear entry, cubic exit.*|
| `EaseInOutCubic` | `float` | `float` | *Cubic entry and exit, linear middle.*|
| `EaseInQuart` | `float` | `float` |  *Fourth degree entry, linear exit.*|
| `EaseOutQuart` | `float` | `float` | *Linear entry, fourth degree exit.*|
| `EaseInOutQuart` | `float` | `float` | *Fourth degree entry and exit, linear middle.*|
| `EaseInQuint` | `float` | `float` | *Fifth degree entry, linear exit.* |
| `EaseOutQuint` | `float` | `float` | *Linear entry, fifth degree exit.*|
| `EaseInOutQuint` | `float` | `float` | *Fifth degree entry and exit, linear middle.*|
| `EaseInExpo` | `float` | `float` |  *Exponential entry, linear exit.*|
| `EaseOutExpo` | `float` | `float` | *Linear entry, exponential exit.*|
| `EaseInOutExpo` | `float` | `float` | *Exponential entry and exit, linear middle.*|
| `EaseInCirc` | `float` | `float` |  *Circular arc entry, linear exit.*|
| `EaseOutCirc` | `float` | `float` | *Linear entry, circular arc exit.*|
| `EaseInOutCirc` | `float` | `float` | *Circular arc entry and exit, linear middle.*|
| `EaseInBack` | `float` | `float` |  *Drop below zero, then linearly increase.*|
| `EaseOutBack` | `float` | `float` | *Linearly increase, then go past one.*|
| `EaseInOutBack` | `float` | `float` | *Drop below zero, linearly increase, then go past one.*|
| `EaseInElastic` | `float` | `float` |  *Elastic effect on entry, linear exit.*|
| `EaseOutElastic` | `float` | `float` | *Linear entry, elastic effect on exit.*|
| `EaseInOutElastic` | `float` | `float` | *Elastic effect on entry and exit, linear middle.*|
| `EaseInBounce` | `float` | `float` |  *Bounce effect on entry, linear exit.*|
| `EaseOutBounce` | `float` | `float` | *Linear entry, bounce effect on exit.*|
| `EaseInOutBounce` | `float` | `float` | *Bounce effect on entry and exit, linear middle.*|