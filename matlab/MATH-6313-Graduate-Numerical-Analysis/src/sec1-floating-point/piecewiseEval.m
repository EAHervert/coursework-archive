% piecewiseEval.m
% Evaluate f(x) = (1 - cos(x)) / x^2 = f1(x) by rewriting it to avoid having difficulties at x = 0
% f(x) = 2x^(-2)((1 - cos(x)) / 2) = 2x^(-2)(sin^2(x / 2)) = f2(x)
% We will use f1(x) when |x| > 1 (Not taking care of the other cases when cos(x) = 1)
% We will use f2(x) when |x| <= 1 since cos(x) approx 1 and we get subtraction cancelation in this case
% At x = 0, the function is undefined.
function y = piecewiseEval(x)
    % Input: value x
    % Output: f(x) based on where x is
    if abs(x) > 1
        y = (1 - cos(x)) / (x ^ 2);
    elseif abs(x) <= 1 && x ~= 0
        y = 2 * x ^ (-2) * sin(x / 2) ^ 2;
    else
        y = NaN;
    end
end