% sqrtDiffReliable.m
% Calculate f(x) = sqrt(x^2 + 1) - 1 by rewriting as f(x) = x^2 / (sqrt(x^2 + 1) + 1)
% This avoids subtracting near similar numbers when x ~ 0
function f = sqrtDiffReliable(x)
    % Input: array of values x
    % Output: f(x_i) for x_i in x
    f = x.^2 ./ (sqrt(x.^2 + 1) + 1);
end