# Floating-Point Arithmetic

**Course:** MATH-6313 — Graduate Numerical Analysis  
**Programs in this pass:**
- [`machineEpsilon.java`](./machineEpsilon.java) — empirical $\varepsilon$ for single and double precision
- [`sqrtDiffNaive.m`](./sqrtDiffNaive.m) — naive $\sqrt{x^2+1} - 1$
- [`sqrtDiffReliable.m`](./sqrtDiffReliable.m) — reliable rewrite $\dfrac{x^2}{\sqrt{x^2+1} + 1}$
- [`piecewiseEval.m`](./piecewiseEval.m) — piecewise evaluation of $(1 - \cos x)/x^2$

## Machine Epsilon

Floating-point numbers are represented by bits. The IEEE 754 format stores these floats using three bit groupings:

- **Sign $s$** (1 bit): sign of the float
- **Exponent $e$** (8 bits / 11 bits): power-of-2 scaling factor
- **Mantissa $m$** (23 bits / 52 bits): fractional bits of the normalized significand

That is, a normal floating-point number is represented as:

$$
x = (-1)^s \cdot 1.m \cdot 2^{\,e - \text{bias}}
$$

Note the bias $= 127$ for single and $1023$ for double precision.

Because of the discrete nature of this representation, there is a gap between $1$ and the next representable float, denoted $\varepsilon$ and called **machine epsilon**. This is the smallest positive $\varepsilon$ such that $1 + \varepsilon \neq 1$ in floating-point arithmetic.

`machineEpsilon.java` computes $\varepsilon$ for single and double precision by starting from $1 = 2^0$ and halving until $1 + \varepsilon = 1$.

**Results:**
- Single precision (32-bit `float`):  $\varepsilon = 2^{-23}$
- Double precision (64-bit `double`): $\varepsilon = 2^{-52}$

The exponents $23$ and $52$ are exactly the number of stored mantissa bits in each format.

## Difference Calculation

When calculating differences, it can be seen that if the values are really close to each other, then the difference may be indistinguishable from zero, leading to incorrect calculations. To overcome this, we oftentimes must rewrite our expression to avoid these numerically unstable calculations.

### Example 1
Take the following function as is:

**Naive form.**
$$
f_{\text{naive}}(x) = \sqrt{x^2 + 1} - 1
$$

We see that when x is really small, the term $\sqrt{x^2 + 1}$ gets really close to 1, and the difference becomes indistinguishable from 0.

We can overcome this by rewriting the expression in a form that avoids this difference entirely.

**Reliable form.**
$$
f_{\text{reliable}}(x) = \frac{x^2}{\sqrt{x^2 + 1} + 1}
$$

**Results.**

We test these two functions for values $8^{-k}$ where $k = 1, 2, ..., 10$ and we can see that `sqrtDiffNaive.m` computes values close to zero rather incorrectly while `sqrtDiffReliable.m` is able to better compute these values. 

| $k$ | Naive        | Reliable       | Reference    |
|----:|------------------------:|------------------------:|------------------------:|
|  1  | $7.8125 \times 10^{-3}$ | $7.8125 \times 10^{-3}$ | $7.8125 \times 10^{-3}$ |
|  2  | $1.2206 \times 10^{-4}$ | $1.2206 \times 10^{-4}$ | $1.2207 \times 10^{-4}$ |
|  3  | $1.9073 \times 10^{-6}$ | $1.9073 \times 10^{-6}$ | $1.9073 \times 10^{-6}$ |
|  4  | $2.9802 \times 10^{-8}$ | $2.9802 \times 10^{-8}$ | $2.9802 \times 10^{-8}$ |
|  5  | $4.6566 \times 10^{-10}$| $4.6566 \times 10^{-10}$| $4.6566 \times 10^{-10}$|
|  6  | $7.2760 \times 10^{-12}$| $7.2760 \times 10^{-12}$| $7.2760 \times 10^{-12}$|
|  7  | $1.1369 \times 10^{-13}$| $1.1369 \times 10^{-13}$| $1.1369 \times 10^{-13}$|
|  8  | $1.7764 \times 10^{-15}$| $1.7764 \times 10^{-15}$| $1.7764 \times 10^{-15}$|
|  9  | $\mathbf{0}$            | $2.7756 \times 10^{-17}$| $2.7756 \times 10^{-17}$|
| 10  | $\mathbf{0}$            | $4.3368 \times 10^{-19}$| $4.3368 \times 10^{-19}$|


Clearly the Reliable calculation handles smaller values better than the Naive approach. Note that the failure at $k = 9$ for the Naive calculation is a result of our values falling below $\varepsilon / 2$.

### Example 2
Now take the following function:

$$f(x) = \frac{1 - \cos(x)}{x^2} = 2 x^{-2}\left(\sin^2\left(\frac{x}{2}\right)\right)$$

We see that in the first representation of the expression, when $\cos(x)$ is close to 1, then we have that $\cos(x) \approx 1$ and we get that dreaded $1 - 1$ issue. To remedy this, we will then take the following approach:
- when $|x| \leq 1$, then we will use $f(x) = 2 x^{-2}\left(\sin^2\left(\frac{x}{2}\right)\right)$
- when $|x| > 1$, then we will use $f(x) = \frac{1 - \cos(x)}{x^2}$

`piecewiseEval.m` implements this process to define a more numerically stable computation for $f(x)$.
