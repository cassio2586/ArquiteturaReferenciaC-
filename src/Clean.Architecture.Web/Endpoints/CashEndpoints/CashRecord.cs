﻿namespace Clean.Architecture.Web.Endpoints.CashEndpoints;

public record CashRecord(string description, decimal amount, int transactionType);
