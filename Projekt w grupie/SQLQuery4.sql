Select nazwa_użytkownika, Punktacja , RANK() over (order by Punktacja desc) as "Miejsce"
FROM wyniki;