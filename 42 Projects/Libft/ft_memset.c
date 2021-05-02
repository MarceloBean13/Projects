/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memset.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:39:37 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:40:21 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>

void	*ft_memset(void *str, int i, size_t size)
{
	while (size > 0)
	{
		size--;
		((unsigned char*)str)[size] = (unsigned char)i;
	}
	return (str);
}
