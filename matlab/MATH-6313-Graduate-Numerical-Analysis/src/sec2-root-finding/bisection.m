% bisection.m
% This function will take a function and two points a < b and find the root
% by bisecting the interval until f(c) = 0.
function x = bisection(fun, a, b)
%   x = bisection(fun, a, b) returns the approximate root of function fun
%   Uses value c = (a + b) / 2 and the criterion sign(fun(a)) ~= sign(fun(c))
%   Uses delta = 1e-8 and a max of 1e3 iterations.

% The algorithm runs up to max_iter and ends after these iterations or if
% |f(c)| < delta.
delta    = 1e-8;
max_iter = 1e3;

% Check endpoints
if abs(fun(a)) < delta
    x = a;
    return
end
if abs(fun(b)) < delta
    x = b;
    return
end

% Perform the bisection up to max_iter times to find root of the function
for i = 1:max_iter
    c = (b + a) / 2;   % Midpoint c of the interval (a, b)
    if abs(fun(c)) < delta
        x = c;
        return
    end
    if sign(fun(a)) * sign(fun(c)) < 0
        b = c;
    else
        a = c;
    end
end

% Return last midpoint if root was not found at adequate tolerance
x = c;
end