select * from autobarn_pricelist
select * from maindealer_pricelist

select * from maindealer_pricelist md
join autobarn_pricelist ab on md.manufacturer == ab.manufacturer

select distinct md.Model
, ab.OilService [AB.OilService]
, md.OilService [MD.OilService]
, ab.AnnualService[AB.AnnualService]
, md.AnnualService[MD.AnnualService]
, ab.MajorService[AB.MajorService]
, md.MajorService [MD.MajorService]
from maindealer_pricelist md
join autobarn_pricelist ab on md.manufacturer = ab.manufacturer and md.model = ab.model
where md.manufacturer = 'audi'
order by md.model


