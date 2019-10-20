
INNER JOIN admissions a AND s.hadm_id = a.hadm_id
INNER JOIN patients p AND s.subject_id =p.subject_id
,transfers t
INNER JOIN admissions a AND t.hadm_id = a.hadm_id
INNER JOIN patients p AND t.subject_id =p.subject_id
INNER JOIN icustays  i AND t.subject_id =i.icustay_id
,inputevents_cv in_cv
INNER JOIN admissions a AND in_cv.hadm_id = a.hadm_id
INNER JOIN patients p AND in_cv.subject_id =p.subject_id
INNER JOIN icustays i AND in_cv.icustay_id =i.icustay_id
INNER JOIN d_items d AND in_cv.itemid =d.itemid
INNER JOIN caregivers car AND in_cv.cgid = car.cgid
,inputevents_mv in_mv
INNER JOIN admissions a AND in_mv.hadm_id = a.hadm_id
INNER JOIN patients p AND in_mv.subject_id =p.subject_id
INNER JOIN icustays i AND in_mv.icustay_id =i.icustay_id
INNER JOIN d_items d AND in_mv.itemid =d.itemid
INNER JOIN caregivers car AND in_mv.cgid = car.cgid
,noteevents n
INNER JOIN admissions a AND n.hadm_id = a.hadm_id
INNER JOIN patients p AND n.subject_id =p.subject_id
INNER JOIN caregivers car AND n.cgid = car.cgid
,outputevent o
INNER JOIN admissions a AND o.hadm_id = a.hadm_id
INNER JOIN patients p AND o.subject_id =p.subject_id
INNER JOIN icustays i AND o.icustay_id =i.icustay_id
INNER JOIN d_items d AND o.itemid =d.itemid
INNER JOIN caregivers car AND o.cgid = car.cgid
,procedureevents_mv as pr_mv
INNER JOIN admissions a AND pr_mv.hadm_id = a.hadm_id
INNER JOIN patients p AND pr_mv.subject_id =p.subject_id
INNER JOIN d_icd_procedures d_p AND pr_mv.icd9_code =d_p.icd9_code
,cptevents cp
INNER JOIN admissions a AND cp.hadm_id = a.hadm_id
INNER JOIN patients p AND cp.subject_id =p.subject_id
,drgcodes dr
INNER JOIN admissions a AND dr.hadm_id = a.hadm_id
INNER JOIN patients p AND dr.subject_id =p.subject_id
,labevents l
INNER JOIN admissions a AND l.hadm_id = a.hadm_id
INNER JOIN patients p AND l.subject_id =p.subject_id
INNER JOIN d_labitems d_l AND l.itemid =d_l.itemid
,microbiologyevents m
INNER JOIN admissions a AND m.hadm_id = a.hadm_id
INNER JOIN patients p AND m.subject_id =p.subject_id
INNER JOIN d_items d AND m.spec_itemid =d.itemid
,prescriptions pre
INNER JOIN admissions a AND pre.hadm_id = a.hadm_id
INNER JOIN patients p AND pre.subject_id =p.subject_id
INNER JOIN icustays  i AND pre.subject_id =i.icustay_id
,d_icd_diagnoses d_d
INNER JOIN diagnoses_icd dia AND d_d.icd9_code = dia.icd9_code
