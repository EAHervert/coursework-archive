# Root Finding
**Course:** MATH-6313 - Graduate Numerical Analysis
**Programs in this pass:**
- [`bisection.m`](./bisection.m) - Bisection method for root finding
- [`newtonScalar.m`](./newtonScalar.m) - Newton's method for root finding - scalar version
- [`newtonSystem.m`](./newtonSystem.m) - Newton's method for root finding - system (vector) version

## Bisection Method
Given a function $f(x)$ on an interval $[a, b]$ where the signs of the function differ when evaluated at the endpoints, we can use the bisection method to find a value $x_r$ such that $f(x_r) = 0$.

We perform this search as follows:

1. Define $c = (a + b) / 2$.
2. Evaluate $f(c)$; if it is within tolerance, return $c$.
3. If not within tolerance, replace $[a, b]$ with either $[a, c]$ or $[c, b]$ depending on the sign of $f(c)$, then go back to step 1.

Terminate the loop if the maximum number of iterations has been performed.

### Example 1
Let $f(x) = x^{-1} - \tan(x)$ on the interval $\left[0, \frac{\pi}{2}\right]$. Since the function is not defined at either endpoint, we actually run the search on $\left[\epsilon, \frac{\pi}{2} - \epsilon\right]$. Running the algorithm, we find

$$c = 0.860333589724671, \quad f(c) = -2.611035831989739 \times 10^{-9}.$$

### Example 2
Let $f(x) = x^{-1} - 2^{x}$ on the interval $[0, 1]$. Since the function is not defined at the left endpoint, we actually run the search on $[\epsilon, 1]$. Running the algorithm, we find

$$c = 0.641185741734448, \quad f(c) = 9.734075989697999 \times 10^{-9}.$$

## Newton's Method - Scalar Version
Another method for finding roots is Newton's method. We derive it by first considering the equation of the tangent line to $f(x)$ at $x_0$:

$$y = f(x_0) + f'(x_0)(x - x_0).$$

Since we are interested in the root of the function, that is, the value $x_r$ such that $f(x_r) = 0$, i.e. the pair $(x_r, 0)$, plugging this in gives

$$0 = f(x_0) + f'(x_0)(x_r - x_0) \Rightarrow x_r = x_0 - \frac{f(x_0)}{f'(x_0)}.$$

Note that for this to work we require $f'(x_0) \neq 0$. From this we define the iterative step

$$x_{n+1} = x_n - \frac{f(x_n)}{f'(x_n)}.$$

### Example 3 - A starting point where Newton's method fails
Take $f(x) = \tan^{-1}(x)$, $f'(x) = \frac{1}{1 + x^2}$, so that the Newton step for this $f$ is

$$x_{n+1} = x_n - (1 + x_n^2)\tan^{-1}(x_n).$$

We are looking for the starting value at which Newton's method will **not** converge. The failure mode here is a two-cycle, so we look for the case $x_{n+1} = -x_n$, since this is where the iteration enters a cycle and never makes progress. Substituting the Newton step:

$$-x_n = x_n - (1 + x_n^2)\tan^{-1}(x_n) \Rightarrow 2x_n - (1 + x_n^2)\tan^{-1}(x_n) = 0.$$

So the cycle point is itself a root-finding problem. Define

$$g(x) = 2x - (1 + x^2)\tan^{-1}(x), \quad g'(x) = 1 - 2x\tan^{-1}(x)$$

Hand $g$ and $g'$ to `newtonScalar.m`. Starting from $x_0 = 1$, we then get:

$$x_r = 1.391745200270735.$$

This $x_r$ is the threshold starting point for $\tan^{-1}(x)$: starting at exactly $x_0 = x_r$ produces the cycle $x_1 = -x_r$, $x_2 = x_r$, and so on. The cycle is repelling, so a nearby start escapes it and the sign of $\epsilon$ decides the outcome: $x_0 = x_r - \epsilon$ alternates in sign with shrinking magnitude and converges to the true root $x = 0$, while $x_0 = x_r + \epsilon$ grows without bound: by roughly the 26th iteration $x_n^2$ overflows, the update becomes `Inf - Inf`, and `newtonScalar.m` returns `NaN` (the guard `abs(fun(x)) >= delta` is false for `NaN`, so the loop exits early rather than running to `max_iter`).

## Newton's Method - Vector Version (System of Equations)

Instead of a function $f : \mathbb{R} \rightarrow \mathbb{R}$, consider a function of several variables $F : \mathbb{R}^n \rightarrow \mathbb{R}^n$. From the higher-dimensional Taylor expansion we can define an update rule to find the vector $\mathbf{x}_r$ such that $F(\mathbf{x}_r) = \mathbf{0}$. The process is

$$\mathbf{x}_{n+1} = \mathbf{x}_n - J(\mathbf{x}_n)^{-1} F(\mathbf{x}_n),$$

where $J(\mathbf{x}_n)^{-1}$ acts as the higher-dimensional version of dividing by $f'(x_n)$.

Note: In `newtonSystem.m` the inverse is never formed explicitly; the step is computed with a linear solve (`jacob(x) \ mult_fun(x)`), which is the same math but better conditioned.

### Example 4 - A 2x2 nonlinear system
Solve

$$
\begin{cases}
4y^2 + 4y + 52x = 19, \\
169x^2 + 3y^2 + 111x - 10y = 10.
\end{cases}
$$

Moving everything to one side,

$$f_1(x, y) = 4y^2 + 4y + 52x - 19, \qquad f_2(x, y) = 169x^2 + 3y^2 + 111x - 10y - 10.$$

The Jacobian is

$$
J(X) =
\begin{bmatrix}
\dfrac{\partial f_1}{\partial x} & \dfrac{\partial f_1}{\partial y} \\[6pt]
\dfrac{\partial f_2}{\partial x} & \dfrac{\partial f_2}{\partial y}
\end{bmatrix},
$$

with

$$\frac{\partial f_1}{\partial x} = 52, \quad \frac{\partial f_1}{\partial y} = 8y + 4,$$

$$\frac{\partial f_2}{\partial x} = 338x + 111, \quad \frac{\partial f_2}{\partial y} = 6y - 10.$$

So for Newton's method for systems where $X = [x, y]^{T}$, we have

$$
F(X) = \begin{bmatrix} f_1(x, y) \\ f_2(x, y) \end{bmatrix} =
\begin{bmatrix} 4y^2 + 4y + 52x - 19 \\ 169x^2 + 3y^2 + 111x - 10y - 10 \end{bmatrix},
$$

$$
J(X) = F'(X) =
\begin{bmatrix}
52 & 8y + 4 \\
338x + 111 & 6y - 10
\end{bmatrix}.
$$

Running this in MATLAB from the initial guess $X_0 = [0, 0]^{T}$:

$$
\mathbf{x}_r = \begin{bmatrix} 0.134197052397750 \\ 1.304283325542098 \end{bmatrix}, \qquad
F(\mathbf{x}_r) = \begin{bmatrix} 0 \\ -1.77635683940025 \times 10^{-15} \end{bmatrix},
$$

$$\lVert F(\mathbf{x}_r) \rVert = 1.776356839400251 \times 10^{-15}.$$

Thus, $\mathbf{x}_r$ is an accurate root of the system.