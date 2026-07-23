% newtonSystem.m
function x = newtonSystem(mult_fun, jacob, x)
% Newton method (vector-valued function).
%   x = newtonSystem(mult_fun, jacob, x) iterates
%       x_{k+1} = x_k - jacob(x_k)^-1 * mult_fun(x_k)
%   Uses delta = 1e-8 and a max of 1e3 iterations.

delta        = 1e-8;   % Our tolerance.
max_iter     = 1e3;    % Maximum number of iterations.
current_iter = 1;      % Initialization.

% The algorithm runs up to max_iter and ends after these iterations or if
% norm(mult_fun(x)) < delta.
while (norm(mult_fun(x)) >= delta && current_iter < max_iter)
    x = x - jacob(x) \ mult_fun(x);   % A \ B == A^-1 * B
    current_iter = current_iter + 1;
end
end