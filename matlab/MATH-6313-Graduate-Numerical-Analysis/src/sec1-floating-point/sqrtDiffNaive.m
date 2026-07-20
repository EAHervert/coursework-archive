% sqrtDiffNaive.m
% Naive calculation of f(x) = sqrt(x^2 + 1) - 1 for values in x
function f = sqrtDiffNaive(x)
    % Input: array of values x
    % Output: f(x_i) for x_i in x
    f = sqrt(x.^2 + 1) - 1;
end