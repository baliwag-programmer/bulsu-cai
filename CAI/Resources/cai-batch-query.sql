SELECT
	sy_from, sy_to,
	CONCAT(sy_from, "-", sy_to) as SY, year as student_year,
	(
		SELECT COUNT(*) FROM users as students
			WHERE (
				students.sy_from = BATCH.sy_from
                AND 
				students.sy_to = BATCH.sy_to
                AND 
				students.year = BATCH.year
			)
	) as total_students,
	(
		SELECT COUNT(distinct(section)) FROM users as students
			WHERE (
				students.sy_from = BATCH.sy_from
                AND 
				students.sy_to = BATCH.sy_to
                AND 
				students.year = BATCH.year
			)
	) as total_sections
    FROM users AS BATCH
    WHERE sy_from IS NOT NULL AND sy_to IS NOT NULL AND year IS NOT NULL
    GROUP BY sy_from, sy_to, year
