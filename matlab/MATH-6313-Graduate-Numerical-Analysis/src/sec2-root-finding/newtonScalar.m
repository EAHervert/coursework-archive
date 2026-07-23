% newtonScalar.m
function x = newtonScalar(fun, dfun, x)
% Newton method (scalar).
%   x = newtonScalar(fun, dfun, x) iterates x_{k+1} = x_k - fun(x_k) / dfun(x_k)
%   Uses delta = 1e-8 and a max of 1e3 iterations.

delta        = 1e-8; % Our tolerance.
max_iter     = 1e3; % Maximum number of iterations.
current_iter = 1; % Initialization.

% The algorithm runs up to max_iter and ends after these iterations or if
% |fun(x)| < delta.
while (abs(fun(x)) >= delta && current_iter < max_iter)
    x = x - fun(x) / dfun(x);
    current_iter = current_iter + 1;
end

end